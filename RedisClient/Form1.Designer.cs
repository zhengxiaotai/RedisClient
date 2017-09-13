namespace RedisClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtDB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPort = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtIP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.grdData = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteKeyValue = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddKeyValue = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdKeys = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtExpire = new DevExpress.XtraEditors.TextEdit();
            this.btnExpire = new DevExpress.XtraEditors.CheckButton();
            this.btnAddKey = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilter = new DevExpress.XtraEditors.TextEdit();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnFlush = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIP.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpire.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 552);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.txtDB);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtPassword);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtPort);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtIP);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(568, 74);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Database Info";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(476, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDB
            // 
            this.txtDB.EditValue = "0";
            this.txtDB.Location = new System.Drawing.Point(396, 35);
            this.txtDB.Name = "txtDB";
            this.txtDB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDB.Properties.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.txtDB.Size = new System.Drawing.Size(50, 20);
            this.txtDB.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(375, 38);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(15, 14);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "DB";
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "admin";
            this.txtPassword.Location = new System.Drawing.Point(286, 35);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(80, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(229, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Password";
            // 
            // txtPort
            // 
            this.txtPort.EditValue = "6379";
            this.txtPort.Location = new System.Drawing.Point(161, 35);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(60, 20);
            this.txtPort.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(132, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Port";
            // 
            // txtIP
            // 
            this.txtIP.EditValue = "172.20.18.200";
            this.txtIP.Location = new System.Drawing.Point(25, 35);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "IP";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 80);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(574, 472);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupControl5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupControl4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(229, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(345, 472);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.grdData);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(3, 68);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(339, 401);
            this.groupControl5.TabIndex = 4;
            this.groupControl5.Text = "Data";
            // 
            // grdData
            // 
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.Location = new System.Drawing.Point(2, 21);
            this.grdData.MainView = this.gridView2;
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(335, 378);
            this.grdData.TabIndex = 0;
            this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3});
            this.gridView2.GridControl = this.grdData;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Value";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnDeleteKeyValue);
            this.groupControl4.Controls.Add(this.btnAddKeyValue);
            this.groupControl4.Controls.Add(this.btnModify);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(3, 3);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(339, 59);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Data Options";
            // 
            // btnDeleteKeyValue
            // 
            this.btnDeleteKeyValue.Location = new System.Drawing.Point(76, 27);
            this.btnDeleteKeyValue.Name = "btnDeleteKeyValue";
            this.btnDeleteKeyValue.Size = new System.Drawing.Size(60, 23);
            this.btnDeleteKeyValue.TabIndex = 13;
            this.btnDeleteKeyValue.Text = "Delete";
            this.btnDeleteKeyValue.Click += new System.EventHandler(this.btnDeleteKeyValue_Click);
            // 
            // btnAddKeyValue
            // 
            this.btnAddKeyValue.Location = new System.Drawing.Point(10, 27);
            this.btnAddKeyValue.Name = "btnAddKeyValue";
            this.btnAddKeyValue.Size = new System.Drawing.Size(60, 23);
            this.btnAddKeyValue.TabIndex = 12;
            this.btnAddKeyValue.Text = "Add";
            this.btnAddKeyValue.Click += new System.EventHandler(this.btnAddKeyValue_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(142, 27);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(60, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Apply";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupControl3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(229, 472);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grdKeys);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 123);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(223, 346);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Keys";
            // 
            // grdKeys
            // 
            this.grdKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKeys.Location = new System.Drawing.Point(2, 21);
            this.grdKeys.MainView = this.gridView1;
            this.grdKeys.Name = "grdKeys";
            this.grdKeys.Size = new System.Drawing.Size(219, 323);
            this.grdKeys.TabIndex = 2;
            this.grdKeys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.grdKeys;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Keys";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtExpire);
            this.groupControl3.Controls.Add(this.btnExpire);
            this.groupControl3.Controls.Add(this.btnAddKey);
            this.groupControl3.Controls.Add(this.txtFilter);
            this.groupControl3.Controls.Add(this.btnClear);
            this.groupControl3.Controls.Add(this.btnFlush);
            this.groupControl3.Controls.Add(this.btnDelete);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(223, 114);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Key Options";
            // 
            // txtExpire
            // 
            this.txtExpire.EditValue = "";
            this.txtExpire.Location = new System.Drawing.Point(80, 86);
            this.txtExpire.Name = "txtExpire";
            this.txtExpire.Size = new System.Drawing.Size(62, 20);
            this.txtExpire.TabIndex = 9;
            // 
            // btnExpire
            // 
            this.btnExpire.Location = new System.Drawing.Point(12, 85);
            this.btnExpire.Name = "btnExpire";
            this.btnExpire.Size = new System.Drawing.Size(62, 23);
            this.btnExpire.TabIndex = 14;
            this.btnExpire.Text = "Expire";
            this.btnExpire.Click += new System.EventHandler(this.btnExpire_Click);
            // 
            // btnAddKey
            // 
            this.btnAddKey.Location = new System.Drawing.Point(12, 56);
            this.btnAddKey.Name = "btnAddKey";
            this.btnAddKey.Size = new System.Drawing.Size(62, 23);
            this.btnAddKey.TabIndex = 11;
            this.btnAddKey.Text = "Add";
            this.btnAddKey.Click += new System.EventHandler(this.btnAddKey_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 28);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(142, 20);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyUp);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(160, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFlush
            // 
            this.btnFlush.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnFlush.Appearance.Options.UseForeColor = true;
            this.btnFlush.Location = new System.Drawing.Point(148, 56);
            this.btnFlush.Name = "btnFlush";
            this.btnFlush.Size = new System.Drawing.Size(62, 23);
            this.btnFlush.TabIndex = 3;
            this.btnFlush.Text = "Flush DB";
            this.btnFlush.Click += new System.EventHandler(this.btnFlush_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(80, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Redis Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIP.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtExpire.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtIP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPort;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit txtDB;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtFilter;
        private DevExpress.XtraGrid.GridControl grdKeys;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnFlush;
        private DevExpress.XtraEditors.SimpleButton btnAddKeyValue;
        private DevExpress.XtraEditors.SimpleButton btnAddKey;
        private DevExpress.XtraEditors.SimpleButton btnDeleteKeyValue;
        private DevExpress.XtraEditors.TextEdit txtExpire;
        private DevExpress.XtraEditors.CheckButton btnExpire;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}

