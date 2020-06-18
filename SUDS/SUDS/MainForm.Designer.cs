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
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.организаторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.судьиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.соревнованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.соревнованияToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // видыСпортаToolStripMenuItem
            // 
            this.видыСпортаToolStripMenuItem.Name = "видыСпортаToolStripMenuItem";
            this.видыСпортаToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.видыСпортаToolStripMenuItem.Text = "Виды спорта";
            this.видыСпортаToolStripMenuItem.Click += new System.EventHandler(this.видыСпортаToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // соревнованияToolStripMenuItem
            // 
            this.соревнованияToolStripMenuItem.Name = "соревнованияToolStripMenuItem";
            this.соревнованияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.соревнованияToolStripMenuItem.Text = "Соревнования";
            this.соревнованияToolStripMenuItem.Click += new System.EventHandler(this.соревнованияToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 456);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem соревнованияToolStripMenuItem;
    }
}

