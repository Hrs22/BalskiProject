namespace BalskiProject.View
{
    partial class AdminMainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainView));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.accTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBoxPassword = new System.Windows.Forms.RichTextBox();
            this.txtBoxEmail = new System.Windows.Forms.RichTextBox();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtBoxHelloSir = new System.Windows.Forms.RichTextBox();
            this.txtBoxInfo = new System.Windows.Forms.RichTextBox();
            this.toolTipEmail = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUserAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUserRemove = new System.Windows.Forms.ToolTip(this.components);
            this.balskiDbContexDataSet = new BalskiProject.BalskiDbContexDataSet();
            this.accTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accTableTableAdapter = new BalskiProject.BalskiDbContexDataSetTableAdapters.AccTableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balskiDbContexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.accTableBindingSource1;
            this.dgv.Location = new System.Drawing.Point(141, 169);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(344, 124);
            this.dgv.TabIndex = 11;
            // 
            // accTableBindingSource
            // 
            this.accTableBindingSource.DataMember = "AccTable";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.AccessibleName = "";
            this.txtBoxPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxPassword.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtBoxPassword.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(337, 318);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(221, 30);
            this.txtBoxPassword.TabIndex = 17;
            this.txtBoxPassword.Tag = "";
            this.txtBoxPassword.Text = "        Password";
            this.txtBoxPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxPassword_MouseClick);
            this.txtBoxPassword.MouseHover += new System.EventHandler(this.txtBoxPassword_MouseHover);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.AccessibleName = "";
            this.txtBoxEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxEmail.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtBoxEmail.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(78, 318);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(221, 30);
            this.txtBoxEmail.TabIndex = 16;
            this.txtBoxEmail.Text = "         Email ";
            this.txtBoxEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxEmail_MouseClick);
            this.txtBoxEmail.MouseHover += new System.EventHandler(this.txtBoxEmail_MouseHover);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.SystemColors.Info;
            this.btnRemoveUser.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.Location = new System.Drawing.Point(353, 380);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(183, 48);
            this.btnRemoveUser.TabIndex = 15;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            this.btnRemoveUser.MouseHover += new System.EventHandler(this.btnRemoveUser_MouseHover);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddUser.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(90, 380);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(183, 48);
            this.btnAddUser.TabIndex = 14;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            this.btnAddUser.MouseHover += new System.EventHandler(this.btnAddUser_MouseHover);
            // 
            // txtBoxHelloSir
            // 
            this.txtBoxHelloSir.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxHelloSir.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHelloSir.Location = new System.Drawing.Point(199, 36);
            this.txtBoxHelloSir.Name = "txtBoxHelloSir";
            this.txtBoxHelloSir.ReadOnly = true;
            this.txtBoxHelloSir.Size = new System.Drawing.Size(222, 48);
            this.txtBoxHelloSir.TabIndex = 13;
            this.txtBoxHelloSir.Text = "   Hello Sir";
            // 
            // txtBoxInfo
            // 
            this.txtBoxInfo.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxInfo.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInfo.Location = new System.Drawing.Point(90, 106);
            this.txtBoxInfo.Name = "txtBoxInfo";
            this.txtBoxInfo.ReadOnly = true;
            this.txtBoxInfo.Size = new System.Drawing.Size(427, 38);
            this.txtBoxInfo.TabIndex = 12;
            this.txtBoxInfo.Text = "Here you can remove/add users in the project";
            // 
            // balskiDbContexDataSet
            // 
            this.balskiDbContexDataSet.DataSetName = "BalskiDbContexDataSet";
            this.balskiDbContexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accTableBindingSource1
            // 
            this.accTableBindingSource1.DataMember = "AccTable";
            this.accTableBindingSource1.DataSource = this.balskiDbContexDataSet;
            // 
            // accTableTableAdapter
            // 
            this.accTableTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // AdminMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = global::BalskiProject.Properties.Resources.Balski12;
            this.ClientSize = new System.Drawing.Size(636, 465);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtBoxHelloSir);
            this.Controls.Add(this.txtBoxInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainView";
            this.Load += new System.EventHandler(this.AdminMainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balskiDbContexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource accTableBindingSource;
        private System.Windows.Forms.RichTextBox txtBoxPassword;
        private System.Windows.Forms.RichTextBox txtBoxEmail;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.RichTextBox txtBoxHelloSir;
        private System.Windows.Forms.RichTextBox txtBoxInfo;
        private System.Windows.Forms.ToolTip toolTipEmail;
        private System.Windows.Forms.ToolTip toolTipPassword;
        private System.Windows.Forms.ToolTip toolTipUserAdd;
        private System.Windows.Forms.ToolTip toolTipUserRemove;
        private BalskiDbContexDataSet balskiDbContexDataSet;
        private System.Windows.Forms.BindingSource accTableBindingSource1;
        private BalskiDbContexDataSetTableAdapters.AccTableTableAdapter accTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}