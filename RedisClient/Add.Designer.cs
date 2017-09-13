namespace RedisClient
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKey = new DevExpress.XtraEditors.LabelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.txtKey = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comKeyType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblKeyType = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.lblValue = new DevExpress.XtraEditors.LabelControl();
            this.txtValue = new DevExpress.XtraEditors.TextEdit();
            this.lblField = new DevExpress.XtraEditors.LabelControl();
            this.txtField = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comKeyType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtField.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKey
            // 
            this.lblKey.Location = new System.Drawing.Point(14, 36);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(20, 14);
            this.lblKey.TabIndex = 13;
            this.lblKey.Text = "Key";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(95, 137);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(70, 33);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 11;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comKeyType);
            this.groupControl1.Controls.Add(this.lblKeyType);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.lblValue);
            this.groupControl1.Controls.Add(this.txtValue);
            this.groupControl1.Controls.Add(this.lblField);
            this.groupControl1.Controls.Add(this.txtField);
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.lblKey);
            this.groupControl1.Controls.Add(this.txtKey);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(188, 172);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Add a Key";
            // 
            // comKeyType
            // 
            this.comKeyType.EditValue = "String";
            this.comKeyType.Location = new System.Drawing.Point(70, 59);
            this.comKeyType.Name = "comKeyType";
            this.comKeyType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comKeyType.Properties.Items.AddRange(new object[] {
            "String",
            "List(L)",
            "List(R)",
            "Set",
            "ZSet",
            "Hash"});
            this.comKeyType.Size = new System.Drawing.Size(100, 20);
            this.comKeyType.TabIndex = 20;
            this.comKeyType.TextChanged += new System.EventHandler(this.comKeyType_TextChanged);
            // 
            // lblKeyType
            // 
            this.lblKeyType.Location = new System.Drawing.Point(14, 62);
            this.lblKeyType.Name = "lblKeyType";
            this.lblKeyType.Size = new System.Drawing.Size(28, 14);
            this.lblKeyType.TabIndex = 19;
            this.lblKeyType.Text = "Type";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblValue
            // 
            this.lblValue.Location = new System.Drawing.Point(14, 114);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(30, 14);
            this.lblValue.TabIndex = 17;
            this.lblValue.Text = "Value";
            this.lblValue.Visible = false;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(70, 111);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 16;
            this.txtValue.Visible = false;
            // 
            // lblField
            // 
            this.lblField.Location = new System.Drawing.Point(14, 88);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(30, 14);
            this.lblField.TabIndex = 15;
            this.lblField.Text = "Value";
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(70, 85);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(100, 20);
            this.txtField.TabIndex = 14;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 178);
            this.Controls.Add(this.groupControl1);
            this.Name = "Add";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Add Key";
            ((System.ComponentModel.ISupportInitialize)(this.txtKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comKeyType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtField.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblKey;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.TextEdit txtKey;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblValue;
        private DevExpress.XtraEditors.TextEdit txtValue;
        private DevExpress.XtraEditors.LabelControl lblField;
        private DevExpress.XtraEditors.TextEdit txtField;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.ComboBoxEdit comKeyType;
        private DevExpress.XtraEditors.LabelControl lblKeyType;
    }
}