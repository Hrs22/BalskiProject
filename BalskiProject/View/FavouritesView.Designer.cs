namespace BalskiProject.View
{
    partial class FavouritesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavouritesView));
            this.txtBoxHelloSir = new System.Windows.Forms.RichTextBox();
            this.txtBoxInfo = new System.Windows.Forms.RichTextBox();
            this.txtBoxFavs = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxHelloSir
            // 
            this.txtBoxHelloSir.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxHelloSir.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHelloSir.Location = new System.Drawing.Point(136, 28);
            this.txtBoxHelloSir.Name = "txtBoxHelloSir";
            this.txtBoxHelloSir.ReadOnly = true;
            this.txtBoxHelloSir.Size = new System.Drawing.Size(379, 48);
            this.txtBoxHelloSir.TabIndex = 15;
            this.txtBoxHelloSir.Text = "   Hello ";
            // 
            // txtBoxInfo
            // 
            this.txtBoxInfo.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxInfo.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInfo.Location = new System.Drawing.Point(57, 92);
            this.txtBoxInfo.Name = "txtBoxInfo";
            this.txtBoxInfo.ReadOnly = true;
            this.txtBoxInfo.Size = new System.Drawing.Size(525, 38);
            this.txtBoxInfo.TabIndex = 14;
            this.txtBoxInfo.Text = "Here you can see your added favourite shows and movies";
            // 
            // txtBoxFavs
            // 
            this.txtBoxFavs.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxFavs.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFavs.ForeColor = System.Drawing.Color.Indigo;
            this.txtBoxFavs.Location = new System.Drawing.Point(57, 157);
            this.txtBoxFavs.Name = "txtBoxFavs";
            this.txtBoxFavs.ReadOnly = true;
            this.txtBoxFavs.Size = new System.Drawing.Size(525, 234);
            this.txtBoxFavs.TabIndex = 16;
            this.txtBoxFavs.Text = "";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Info;
            this.btnBack.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(181, 38);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FavouritesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = global::BalskiProject.Properties.Resources.Balski12;
            this.ClientSize = new System.Drawing.Size(636, 465);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBoxFavs);
            this.Controls.Add(this.txtBoxHelloSir);
            this.Controls.Add(this.txtBoxInfo);
            this.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FavouritesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FavouritesView";
            this.Load += new System.EventHandler(this.FavouritesView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxHelloSir;
        private System.Windows.Forms.RichTextBox txtBoxInfo;
        private System.Windows.Forms.RichTextBox txtBoxFavs;
        private System.Windows.Forms.Button btnBack;
    }
}