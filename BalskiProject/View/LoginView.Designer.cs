namespace BalskiProject.View
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.txtBoxEmail = new System.Windows.Forms.RichTextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.btnCantLog = new System.Windows.Forms.Button();
            this.toolTipEmail = new System.Windows.Forms.ToolTip(this.components);
            this.btnAreYouAdmin = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.AccessibleName = "";
            this.txtBoxEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxEmail.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtBoxEmail.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(61, 95);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(221, 30);
            this.txtBoxEmail.TabIndex = 0;
            this.txtBoxEmail.Text = "         Email ";
            this.txtBoxEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxEmail_MouseClick);
            this.txtBoxEmail.MouseHover += new System.EventHandler(this.txtBoxEmail_MouseHover);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogIn.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(25, 226);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(292, 53);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.SystemColors.Info;
            this.btnCreateAcc.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.Location = new System.Drawing.Point(48, 381);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(247, 71);
            this.btnCreateAcc.TabIndex = 3;
            this.btnCreateAcc.Text = "Dont have a Balski Account? \r\nCreate a free Account just a click away!!!\r\n";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // btnCantLog
            // 
            this.btnCantLog.BackColor = System.Drawing.SystemColors.Info;
            this.btnCantLog.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantLog.Location = new System.Drawing.Point(87, 482);
            this.btnCantLog.Name = "btnCantLog";
            this.btnCantLog.Size = new System.Drawing.Size(168, 36);
            this.btnCantLog.TabIndex = 4;
            this.btnCantLog.Text = "Trouble signing in?";
            this.btnCantLog.UseVisualStyleBackColor = false;
            this.btnCantLog.Click += new System.EventHandler(this.btnCantLog_Click);
            // 
            // btnAreYouAdmin
            // 
            this.btnAreYouAdmin.BackColor = System.Drawing.SystemColors.Info;
            this.btnAreYouAdmin.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreYouAdmin.Location = new System.Drawing.Point(87, 314);
            this.btnAreYouAdmin.Name = "btnAreYouAdmin";
            this.btnAreYouAdmin.Size = new System.Drawing.Size(230, 37);
            this.btnAreYouAdmin.TabIndex = 5;
            this.btnAreYouAdmin.Text = "If you are Admin click here";
            this.btnAreYouAdmin.UseVisualStyleBackColor = false;
            this.btnAreYouAdmin.Click += new System.EventHandler(this.btnAreYouAdmin_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxPassword.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.txtBoxPassword.Location = new System.Drawing.Point(61, 160);
            this.txtBoxPassword.Multiline = true;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(221, 30);
            this.txtBoxPassword.TabIndex = 6;
            this.txtBoxPassword.Text = "       Password";
            this.txtBoxPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxPassword_MouseClick);
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            this.txtBoxPassword.MouseHover += new System.EventHandler(this.txtBoxPassword_MouseHover);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(329, 569);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.btnAreYouAdmin);
            this.Controls.Add(this.btnCantLog);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtBoxEmail);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxEmail;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Button btnCantLog;
        private System.Windows.Forms.ToolTip toolTipEmail;
        private System.Windows.Forms.Button btnAreYouAdmin;
        private System.Windows.Forms.TextBox txtBoxPassword;
    }
}