namespace BalskiProject
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.txtBoxWelcome = new System.Windows.Forms.RichTextBox();
            this.toolTipListOfGames = new System.Windows.Forms.ToolTip(this.components);
            this.btnChanceAcc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGoTvWeekly = new System.Windows.Forms.Button();
            this.toolTipListOfFilms = new System.Windows.Forms.ToolTip(this.components);
            this.btnGoDailyMovies = new System.Windows.Forms.Button();
            this.picBoxHearth = new System.Windows.Forms.PictureBox();
            this.btnGoWeeklyMovies = new System.Windows.Forms.Button();
            this.btnGoTvDaily = new System.Windows.Forms.Button();
            this.lblFavs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHearth)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxWelcome
            // 
            this.txtBoxWelcome.AccessibleName = "";
            this.txtBoxWelcome.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoxWelcome.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtBoxWelcome.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWelcome.Location = new System.Drawing.Point(159, 28);
            this.txtBoxWelcome.Name = "txtBoxWelcome";
            this.txtBoxWelcome.ReadOnly = true;
            this.txtBoxWelcome.Size = new System.Drawing.Size(260, 41);
            this.txtBoxWelcome.TabIndex = 1;
            this.txtBoxWelcome.Text = "Welcome to Balski";
            // 
            // btnChanceAcc
            // 
            this.btnChanceAcc.BackColor = System.Drawing.SystemColors.Info;
            this.btnChanceAcc.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanceAcc.Location = new System.Drawing.Point(27, 330);
            this.btnChanceAcc.Name = "btnChanceAcc";
            this.btnChanceAcc.Size = new System.Drawing.Size(215, 72);
            this.btnChanceAcc.TabIndex = 5;
            this.btnChanceAcc.Text = "Want to change your account? Click me !\r\n\r\n";
            this.btnChanceAcc.UseVisualStyleBackColor = false;
            this.btnChanceAcc.Click += new System.EventHandler(this.btnChanceAcc_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Info;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(346, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(215, 72);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "\r\nWant to exit? Click me !\r\n\r\n";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGoTvWeekly
            // 
            this.btnGoTvWeekly.BackColor = System.Drawing.SystemColors.Info;
            this.btnGoTvWeekly.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoTvWeekly.Location = new System.Drawing.Point(27, 141);
            this.btnGoTvWeekly.Name = "btnGoTvWeekly";
            this.btnGoTvWeekly.Size = new System.Drawing.Size(201, 57);
            this.btnGoTvWeekly.TabIndex = 7;
            this.btnGoTvWeekly.Text = "Weekly Tv Shows";
            this.btnGoTvWeekly.UseVisualStyleBackColor = false;
            this.btnGoTvWeekly.Click += new System.EventHandler(this.btnGoTvWeekly_Click);
            // 
            // btnGoDailyMovies
            // 
            this.btnGoDailyMovies.BackColor = System.Drawing.SystemColors.Info;
            this.btnGoDailyMovies.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoDailyMovies.Location = new System.Drawing.Point(360, 232);
            this.btnGoDailyMovies.Name = "btnGoDailyMovies";
            this.btnGoDailyMovies.Size = new System.Drawing.Size(201, 57);
            this.btnGoDailyMovies.TabIndex = 9;
            this.btnGoDailyMovies.Text = "Daily Movies";
            this.btnGoDailyMovies.UseVisualStyleBackColor = false;
            this.btnGoDailyMovies.Click += new System.EventHandler(this.btnGoFilmStore_Click);
            // 
            // picBoxHearth
            // 
            this.picBoxHearth.BackColor = System.Drawing.Color.Transparent;
            this.picBoxHearth.Image = global::BalskiProject.Properties.Resources.hearth;
            this.picBoxHearth.Location = new System.Drawing.Point(243, 223);
            this.picBoxHearth.Name = "picBoxHearth";
            this.picBoxHearth.Size = new System.Drawing.Size(100, 79);
            this.picBoxHearth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHearth.TabIndex = 10;
            this.picBoxHearth.TabStop = false;
            this.picBoxHearth.Click += new System.EventHandler(this.picBoxHearth_Click);
            // 
            // btnGoWeeklyMovies
            // 
            this.btnGoWeeklyMovies.BackColor = System.Drawing.SystemColors.Info;
            this.btnGoWeeklyMovies.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoWeeklyMovies.Location = new System.Drawing.Point(360, 141);
            this.btnGoWeeklyMovies.Name = "btnGoWeeklyMovies";
            this.btnGoWeeklyMovies.Size = new System.Drawing.Size(201, 57);
            this.btnGoWeeklyMovies.TabIndex = 11;
            this.btnGoWeeklyMovies.Text = "Weekly Movies";
            this.btnGoWeeklyMovies.UseVisualStyleBackColor = false;
            this.btnGoWeeklyMovies.Click += new System.EventHandler(this.btnGoWeeklyMovies_Click);
            // 
            // btnGoTvDaily
            // 
            this.btnGoTvDaily.BackColor = System.Drawing.SystemColors.Info;
            this.btnGoTvDaily.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoTvDaily.Location = new System.Drawing.Point(27, 232);
            this.btnGoTvDaily.Name = "btnGoTvDaily";
            this.btnGoTvDaily.Size = new System.Drawing.Size(201, 57);
            this.btnGoTvDaily.TabIndex = 12;
            this.btnGoTvDaily.Text = "Daily Tv Shows";
            this.btnGoTvDaily.UseVisualStyleBackColor = false;
            this.btnGoTvDaily.Click += new System.EventHandler(this.btnGoTvDaily_Click);
            // 
            // lblFavs
            // 
            this.lblFavs.AutoSize = true;
            this.lblFavs.BackColor = System.Drawing.Color.Transparent;
            this.lblFavs.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavs.ForeColor = System.Drawing.SystemColors.Info;
            this.lblFavs.Location = new System.Drawing.Point(274, 282);
            this.lblFavs.Name = "lblFavs";
            this.lblFavs.Size = new System.Drawing.Size(37, 20);
            this.lblFavs.TabIndex = 13;
            this.lblFavs.Text = "Favs";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 430);
            this.Controls.Add(this.lblFavs);
            this.Controls.Add(this.btnGoTvDaily);
            this.Controls.Add(this.btnGoWeeklyMovies);
            this.Controls.Add(this.picBoxHearth);
            this.Controls.Add(this.btnGoDailyMovies);
            this.Controls.Add(this.btnGoTvWeekly);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChanceAcc);
            this.Controls.Add(this.txtBoxWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balski";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHearth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxWelcome;
        private System.Windows.Forms.ToolTip toolTipListOfGames;
        private System.Windows.Forms.Button btnChanceAcc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGoTvWeekly;
        private System.Windows.Forms.ToolTip toolTipListOfFilms;
        private System.Windows.Forms.Button btnGoDailyMovies;
        private System.Windows.Forms.PictureBox picBoxHearth;
        private System.Windows.Forms.Button btnGoWeeklyMovies;
        private System.Windows.Forms.Button btnGoTvDaily;
        private System.Windows.Forms.Label lblFavs;
    }
}

