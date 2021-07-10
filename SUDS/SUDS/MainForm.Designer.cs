namespace SUDS
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыСпортаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спортсменыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.организаторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.судьиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соревнованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.пользовательToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видыСпортаToolStripMenuItem,
            this.спортсменыToolStripMenuItem,
            this.соревнованиеToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // видыСпортаToolStripMenuItem
            // 
            this.видыСпортаToolStripMenuItem.Name = "видыСпортаToolStripMenuItem";
            this.видыСпортаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.видыСпортаToolStripMenuItem.Text = "Виды спорта";
            this.видыСпортаToolStripMenuItem.Click += new System.EventHandler(this.видыСпортаToolStripMenuItem_Click);
            // 
            // спортсменыToolStripMenuItem
            // 
            this.спортсменыToolStripMenuItem.Name = "спортсменыToolStripMenuItem";
            this.спортсменыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.спортсменыToolStripMenuItem.Text = "Спортсмены";
            this.спортсменыToolStripMenuItem.Click += new System.EventHandler(this.спортсменыToolStripMenuItem_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.организаторыToolStripMenuItem,
            this.судьиToolStripMenuItem});
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // организаторыToolStripMenuItem
            // 
            this.организаторыToolStripMenuItem.Name = "организаторыToolStripMenuItem";
            this.организаторыToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.организаторыToolStripMenuItem.Text = "Организаторы";
            this.организаторыToolStripMenuItem.Click += new System.EventHandler(this.организаторыToolStripMenuItem_Click);
            // 
            // судьиToolStripMenuItem
            // 
            this.судьиToolStripMenuItem.Name = "судьиToolStripMenuItem";
            this.судьиToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.судьиToolStripMenuItem.Text = "Судьи";
            this.судьиToolStripMenuItem.Click += new System.EventHandler(this.судьиToolStripMenuItem_Click);
            // 
            // соревнованиеToolStripMenuItem
            // 
            this.соревнованиеToolStripMenuItem.Name = "соревнованиеToolStripMenuItem";
            this.соревнованиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.соревнованиеToolStripMenuItem.Text = "Соревнование";
            this.соревнованиеToolStripMenuItem.Click += new System.EventHandler(this.соревнованиеToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 456);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Console";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видыСпортаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem организаторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem судьиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спортсменыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соревнованиеToolStripMenuItem;
    }
}

