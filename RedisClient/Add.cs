using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisClient
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKey.Text) || string.IsNullOrEmpty(txtField.Text))
            {
                return;
            }
            if (comKeyType.SelectedItem.Equals("String"))
            {
                Form1.client.SetValue(txtKey.Text, txtField.Text);
            }
            if (comKeyType.SelectedItem.Equals("List(L)"))
            {
                Form1.client.PrependItemToList(txtKey.Text, txtField.Text);
            }
            if (comKeyType.SelectedItem.Equals("List(R)"))
            {
                Form1.client.AddItemToList(txtKey.Text, txtField.Text);
            }
            if (comKeyType.SelectedItem.Equals("Set"))
            {
                Form1.client.AddItemToSet(txtKey.Text, txtField.Text);
            }
            if (comKeyType.SelectedItem.Equals("ZSet"))
            {
                Form1.client.AddItemToSortedSet(txtKey.Text, txtField.Text, double.Parse(txtValue.Text));
            }
            if (comKeyType.SelectedItem.Equals("Hash"))
            {
                Form1.client.SetEntryInHash(txtKey.Text, txtField.Text, txtValue.Text);
            }
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKey.Text = string.Empty;
            txtField.Text = string.Empty;
            txtValue.Text = string.Empty;
        }

        private void comKeyType_TextChanged(object sender, EventArgs e)
        {
            if (comKeyType.SelectedText.Equals("String"))
            {
                txtValue.Visible = false;
                lblValue.Visible = false;
                lblField.Text = "Value";
            }
            if (comKeyType.SelectedText.Equals("List(L)") || comKeyType.SelectedText.Equals("List(R)"))
            {
                txtValue.Visible = false;
                lblValue.Visible = false;
                lblField.Text = "Value";
            }
            if (comKeyType.SelectedText.Equals("Set"))
            {
                txtValue.Visible = false;
                lblValue.Visible = false;
                lblField.Text = "Value";
            }
            if (comKeyType.SelectedText.Equals("ZSet"))
            {
                txtValue.Visible = true;
                lblValue.Visible = true;
                lblField.Text = "Value";
                lblValue.Text = "Score";
            }
            if (comKeyType.SelectedText.Equals("Hash"))
            {
                txtValue.Visible = true;
                lblValue.Visible = true;
                lblField.Text = "Field";
                lblValue.Text = "Valued";
            }
        }
    }
}
