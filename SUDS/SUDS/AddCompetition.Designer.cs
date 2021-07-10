namespace SUDS
{
    partial class AddCompetition
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KoS = new System.Windows.Forms.ComboBox();
            this.Jud = new System.Windows.Forms.ComboBox();
            this.Spo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Вид спорта:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Дата:";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(110, 207);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(95, 27);
            this.Add.TabIndex = 10;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Судья:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Организатор:";
            // 
            // KoS
            // 
            this.KoS.FormattingEnabled = true;
            this.KoS.Location = new System.Drawing.Point(110, 71);
            this.KoS.Name = "KoS";
            this.KoS.Size = new System.Drawing.Size(147, 21);
            this.KoS.TabIndex = 19;
            // 
            // Jud
            // 
            this.Jud.FormattingEnabled = true;
            this.Jud.Location = new System.Drawing.Point(110, 114);
            this.Jud.Name = "Jud";
            this.Jud.Size = new System.Drawing.Size(147, 21);
            this.Jud.TabIndex = 20;
            // 
            // Spo
            // 
            this.Spo.FormattingEnabled = true;
            this.Spo.Location = new System.Drawing.Point(110, 153);
            this.Spo.Name = "Spo";
            this.Spo.Size = new System.Drawing.Size(147, 21);
            this.Spo.TabIndex = 21;
            // 
            // AddCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 272);
            this.Controls.Add(this.Spo);
            this.Controls.Add(this.Jud);
            this.Controls.Add(this.KoS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Name = "AddCompetition";
            this.Text = "AddCompetition";
            this.Load += new System.EventHandler(this.AddCompetition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Add;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox KoS;
        private System.Windows.Forms.ComboBox Jud;
        private System.Windows.Forms.ComboBox Spo;
    }
}