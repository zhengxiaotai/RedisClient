using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace RedisClient
{
    public partial class Form1 : Form
    {
        string connStr = "";
        RedisClientManagerConfig config;
        string[] ReadWriteConStr = new string[1];
        DataTable table1, table2;
        public static IRedisClient client;
        XmlDocument doc;
        XmlNodeList nodeList;

        string Filter = "";

        public Form1()
        {
            InitializeComponent();
            doc = new XmlDocument();
            doc.Load("connection.xml");
            nodeList = doc.SelectNodes("connection/server");
            foreach (XmlNode item in nodeList)
            {
                txtPreset.Properties.Items.Add(item.Attributes["ip"].Value);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtIP.Text == "" || txtPort.Text == "")
            {
                return;
            }
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormDescription("Connecting...");
            try
            {
                string str = "";
                if (btnPassword.Checked)
                {
                    ReadWriteConStr[0] = "redis://" + txtIP.Text + ":" + txtPort.Text;
                    str = txtIP.Text + ":" + txtPort.Text;
                }
                else
                {
                    ;
                    ReadWriteConStr[0] = "redis://" + txtPassword.Text + "@" + txtIP.Text + ":" + txtPort.Text;
                    str = txtPassword.Text + "@" + txtIP.Text + ":" + txtPort.Text;
                }

                if (!str.Equals(connStr))
                {
                    Console.WriteLine("new connection");
                    PooledRedisClientManager manager = new PooledRedisClientManager(200, 200, ReadWriteConStr);
                    RedisConfig.VerifyMasterConnections = false;
                    client = manager.GetClient();
                    connStr = str;
                }

                splashScreenManager1.SetWaitFormDescription("Executing Query...");
                client.Db = long.Parse(txtDB.Text);
                List<string> list = client.SearchKeys("*");
                splashScreenManager1.SetWaitFormDescription("Loading Data...");

                table1 = new DataTable();
                table1.Columns.Add("Keys");
                DataRow row;
                foreach (string key in list)
                {
                    row = table1.NewRow();
                    row[0] = key;
                    table1.Rows.Add(row);
                }
                grdKeys.DataSource = table1;
                gridView1.PopulateColumns();
                gridView1.Columns[0].OptionsColumn.ReadOnly = false;
                gridView1.Columns[0].OptionsColumn.AllowEdit = false;
                gridView1.Columns[0].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                gridView1.MoveFirst();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message, "Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            splashScreenManager1.CloseWaitForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gridView1.ClearColumnsFilter();
            txtFilter.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (table1 == null)
            {
                return;
            }
            int[] selectRows = gridView1.GetSelectedRows();
            List<string> keyList = new List<string>();

            foreach (int index in selectRows)
            {
                keyList.Add(gridView1.GetRowCellValue(index, "Keys").ToString());
            }
            if (keyList.Count == 0)
            {
                MessageBox.Show("Please Select a Key to Delete", "Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Delete " + keyList.Count + " Keys?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    splashScreenManager1.ShowWaitForm();
                    splashScreenManager1.SetWaitFormDescription("Deleting...");
                    client.RemoveAll(keyList);
                    this.btnSearch_Click(null, null);
                    splashScreenManager1.CloseWaitForm();
                }
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(e.RowHandle);
            string key = row[0].ToString();
            if (client.GetEntryType(key) == RedisKeyType.None)
            {
                MessageBox.Show("Key Does Not Exist or Expired", "Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (client.GetEntryType(key) == RedisKeyType.Hash)
            {
                Dictionary<string, string> keyValues = client.GetAllEntriesFromHash(key);
                if (keyValues.Count == 0)
                {
                    MessageBox.Show("Key Does Not Exist or Expired", "Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                table2 = new DataTable();
                table2.Columns.Add("Key");
                table2.Columns.Add("Value");
                DataRow newRow;
                foreach (var data in keyValues)
                {
                    newRow = table2.NewRow();
                    newRow[0] = data.Key;
                    newRow[1] = data.Value;
                    table2.Rows.Add(newRow);
                }
                btnAddKeyValue.Enabled = true;
                btnDeleteKeyValue.Enabled = true;
            }
            if (client.GetEntryType(key) == RedisKeyType.Set)
            {
                HashSet<string> values = client.GetAllItemsFromSet(key);
                if (values.Count == 0)
                {
                    MessageBox.Show("Key Does Not Exist or Expired", "Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                table2 = new DataTable();
                table2.Columns.Add("Value");
                DataRow newRow;
                foreach (var data in values)
                {
                    newRow = table2.NewRow();
                    newRow[0] = data;
                    table2.Rows.Add(newRow);
                }
                btnAddKeyValue.Enabled = true;
                btnDeleteKeyValue.Enabled = true;
            }
            if (client.GetEntryType(key) == RedisKeyType.SortedSet)
            {
                IEnumerable<KeyValuePair<string, double>> values = client.ScanAllSortedSetItems(key);
                if (values == null)
                {
                    MessageBox.Show("Key Does Not Exist or Expired", "Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                table2 = new DataTable();
                table2.Columns.Add("Value");
                table2.Columns.Add("Score");
                DataRow newRow;
                foreach (var data in values)
                {
                    newRow = table2.NewRow();
                    newRow[0] = data.Key;
                    newRow[1] = data.Value;
                    table2.Rows.Add(newRow);
                }
                btnAddKeyValue.Enabled = true;
                btnDeleteKeyValue.Enabled = true;
            }
            if (client.GetEntryType(key) == RedisKeyType.List)
            {
                long count = client.GetListCount(key);
                List<string> values = client.GetRangeFromList(key, 0, (int)count);
                if (values.Count == 0)
                {
                    MessageBox.Show("Key Does Not Exist or Expired", "Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                table2 = new DataTable();
                table2.Columns.Add("Value");
                DataRow newRow;
                foreach (var data in values)
                {
                    newRow = table2.NewRow();
                    newRow[0] = data;
                    table2.Rows.Add(newRow);
                }
                btnAddKeyValue.Enabled = true;
                btnDeleteKeyValue.Enabled = true;
            }
            if (client.GetEntryType(key) == RedisKeyType.String)
            {
                string value = client.GetValue(key);
                if (value == null)
                {
                    MessageBox.Show("Key Does Not Exist or Expired", "Null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                table2 = new DataTable();
                table2.Columns.Add("Value");
                DataRow newRow = table2.NewRow();
                newRow[0] = value;
                table2.Rows.Add(newRow);
                btnAddKeyValue.Enabled = false;
                btnDeleteKeyValue.Enabled = false;
            }

            TimeSpan time = (TimeSpan)client.GetTimeToLive(key);
            if (time.TotalSeconds > 99999999)
            {
                txtExpire.Text = "";
                btnExpire.Checked = false;
            }
            else
            {
                txtExpire.Text = time.TotalSeconds.ToString();
                btnExpire.Checked = true;
            }

            grdData.DataSource = table2;
            gridView2.PopulateColumns();
            // txtFilter.Text = key;
        }

        private void txtFilter_KeyUp(object sender, KeyEventArgs e)
        {
            this.FilterData(e.KeyCode);
        }

        private void FilterData(Keys key)
        {
            if ((key >= Keys.D0 && key <= Keys.D9) || (key >= Keys.NumPad0 && key <= Keys.NumPad9) || key == Keys.Back || (key >= Keys.A && key <= Keys.Z))
            {
                Filter = "";
                if (!string.IsNullOrEmpty(txtFilter.Text))
                {
                    Filter = "[Keys] LIKE '%" + txtFilter.Text + "%'";
                }
                gridView1.ActiveFilterString = Filter;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (table1 == null || table2 == null)
            {
                return;
            }
            int[] index = gridView1.GetSelectedRows();
            string hashKey = gridView1.GetFocusedDataRow()[0].ToString();
            if (MessageBox.Show("提交" + hashKey + "的改动？", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataRow row;
                string key, value;
                RedisKeyType keyType = client.GetEntryType(hashKey);
                if (keyType == RedisKeyType.String)
                {
                    client.SetValue(hashKey, gridView2.GetDataRow(0)[0].ToString());
                }
                if (keyType == RedisKeyType.List)
                {
                    client.Remove(hashKey);
                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        row = gridView2.GetDataRow(i);
                        value = row[0].ToString();
                        client.AddItemToList(hashKey, value);
                    }
                }
                if (keyType == RedisKeyType.Set)
                {
                    client.Remove(hashKey);
                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        row = gridView2.GetDataRow(i);
                        value = row[0].ToString();
                        client.AddItemToSet(hashKey, value);
                    }
                }
                if (keyType == RedisKeyType.SortedSet)
                {
                    client.Remove(hashKey);
                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        row = gridView2.GetDataRow(i);
                        value = row[0].ToString();
                        key = row[1].ToString();
                        client.AddItemToSortedSet(hashKey, value, double.Parse(key));
                    }
                }
                if (client.GetEntryType(hashKey) == RedisKeyType.Hash)
                {
                    client.Remove(hashKey);
                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        row = gridView2.GetDataRow(i);
                        key = row[0].ToString();
                        value = row[1].ToString();
                        client.SetEntryInHash(hashKey, key, value);
                    }
                }
            }
        }

        private void btnFlush_Click(object sender, EventArgs e)
        {
            if (table1 == null)
            {
                return;
            }
            if (MessageBox.Show("确认清空DB？", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                client.FlushDb();
                this.btnSearch_Click(null, null);
                table2.Clear();
            }
        }

        private void btnAddKey_Click(object sender, EventArgs e)
        {
            if (table1 == null)
            {
                return;
            }
            Add add = new Add();
            add.ShowDialog();
            this.btnSearch_Click(null, null);
        }

        private void btnAddKeyValue_Click(object sender, EventArgs e)
        {
            if (table1 == null || table2 == null)
            {
                return;
            }
            string key = gridView1.GetFocusedDataRow()[0].ToString();
            if (key == null || key.Length == 0)
            {
                return;
            }
            DataRow row = table2.NewRow();
            table2.Rows.Add(row);
        }

        private void btnDeleteKeyValue_Click(object sender, EventArgs e)
        {
            if (table1 == null || table2 == null)
            {
                return;
            }
            string key = gridView1.GetFocusedDataRow()[0].ToString();
            if (key == null || key.Length == 0)
            {
                return;
            }
            int[] index = gridView2.GetSelectedRows();
            if (table2.Rows.Count < 1)
            {
                return;
            }
            table2.Rows.RemoveAt(index[0]);
        }
        
        private void btnExpire_Click(object sender, EventArgs e)
        {
            if (table1 == null || table2 == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtExpire.Text))
            {
                return;
            }
            string hashKey = gridView1.GetFocusedDataRow()[0].ToString();
            if (hashKey == null || hashKey.Length == 0)
            {
                return;
            }
            if (btnExpire.Checked == false)
            {
                TimeSpan expireTime = new TimeSpan(long.Parse(txtExpire.Text) * 10000000);
                client.ExpireEntryIn(hashKey, expireTime);
            }
            else
            {
                RedisKeyType keyType = client.GetEntryType(hashKey);
                client.Remove(hashKey);
                DataRow row;
                string key, value;
                if (keyType == RedisKeyType.String)
                {
                    client.SetValue(hashKey, gridView2.GetDataRow(0)[0].ToString());
                }
                if (keyType == RedisKeyType.List)
                {
                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        row = gridView2.GetDataRow(i);
                        value = row[0].ToString();
                        client.AddItemToList(hashKey, value);
                    }
                }
                if (keyType == RedisKeyType.Set)
                {
                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        row = gridView2.GetDataRow(i);
                        value = row[0].ToString();
                        client.AddItemToSet(hashKey, value);
                    }
                }
                if (keyType == RedisKeyType.SortedSet)
                {
                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        row = gridView2.GetDataRow(i);
                        value = row[0].ToString();
                        key = row[1].ToString();
                        client.AddItemToSortedSet(hashKey, value, double.Parse(key));
                    }
                }
                if (keyType == RedisKeyType.Hash)
                {
                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        row = gridView2.GetDataRow(i);
                        key = row[0].ToString();
                        value = row[1].ToString();
                        client.SetEntryInHash(hashKey, key, value);
                    }
                }
                txtExpire.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtIP.Text == "" || txtPort.Text == "")
            {
                return;
            }
            foreach (XmlNode item in nodeList)
            {
                if (item.Attributes["ip"].Value == txtIP.Text)
                {
                    item.Attributes["port"].Value = txtPort.Text;
                    item.Attributes["hasPassword"].Value = btnPassword.Checked.ToString();
                    item.Attributes["password"].Value = txtPassword.Text;
                    doc.Save("connection.xml");
                    return;
                }
            }
            XmlElement element = doc.CreateElement("server");
            element.SetAttribute("ip", txtIP.Text);
            element.SetAttribute("port", txtPort.Text);
            element.SetAttribute("hasPassword", btnPassword.Checked.ToString());
            element.SetAttribute("password", txtPassword.Text);
            doc.SelectNodes("connection").Item(0).AppendChild(element);
            doc.Save("connection.xml");
            nodeList = doc.SelectNodes("connection/server");
            txtPreset.Properties.Items.Add(txtIP.Text);
            txtPreset.Text = txtIP.Text;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Copy")
            {
                if (gridView1.RowCount == 0)
                {
                    return;
                }
                string key = gridView1.GetFocusedDataRow()[0].ToString();
                Clipboard.SetText(key);
            }
        }

        private void txtPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nodeList == null)
            {
                return;
            }
            int index = txtPreset.SelectedIndex;
            txtIP.Text = nodeList.Item(index).Attributes["ip"].Value;
            txtPort.Text = nodeList.Item(index).Attributes["port"].Value;
            if (nodeList.Item(index).Attributes["hasPassword"].Value.Equals("false"))
            {
                btnPassword.Checked = true;
                txtPassword.Text = "";
            }
            else
            {
                btnPassword.Checked = false;
                txtPassword.Text = nodeList.Item(index).Attributes["password"].Value;
            }
            
        }

        private void btnPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPassword.Checked)
            {
                txtPassword.Text = "";
                txtPassword.Enabled = false;
            }
            else
            {
                txtPassword.Enabled = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client != null)
            {
                client.Dispose();
            }
        }
    }
}
