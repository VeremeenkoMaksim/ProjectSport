﻿namespace SUDS
{
    partial class EditKindOfSport
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
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.selectCategoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Apply = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(150, 96);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(0, 13);
            this.CategoryLabel.TabIndex = 15;
            // 
            // selectCategoryButton
            // 
            this.selectCategoryButton.Location = new System.Drawing.Point(140, 60);
            this.selectCategoryButton.Name = "selectCategoryButton";
            this.selectCategoryButton.Size = new System.Drawing.Size(95, 20);
            this.selectCategoryButton.TabIndex = 14;
            this.selectCategoryButton.Text = "Выбрать";
            this.selectCategoryButton.UseVisualStyleBackColor = true;
            this.selectCategoryButton.Click += new System.EventHandler(this.selectCategoryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Категория";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(100, 24);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(209, 20);
            this.NameBox.TabIndex = 11;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(21, 123);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(95, 27);
            this.Apply.TabIndex = 10;
            this.Apply.Text = "Применить";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(201, 123);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(95, 27);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EditKindOfSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 162);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.selectCategoryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Apply);
            this.Name = "EditKindOfSport";
            this.Text = "EditKindOfSport";
            this.Load += new System.EventHandler(this.EditKindOfSport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button selectCategoryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.Button Apply;
        public System.Windows.Forms.Button Cancel;
    }
}