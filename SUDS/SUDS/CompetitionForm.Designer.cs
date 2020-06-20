namespace SUDS
{
    partial class CompetitionForm
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
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.KoS = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(311, 373);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 33);
            this.Search.TabIndex = 17;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(588, 125);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(117, 30);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(588, 68);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(117, 30);
            this.Edit.TabIndex = 15;
            this.Edit.Text = "Редактировать";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(588, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(117, 30);
            this.Add.TabIndex = 14;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(588, 402);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(117, 30);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 325);
            this.dataGridView1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 362);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // KoS
            // 
            this.KoS.FormattingEnabled = true;
            this.KoS.Location = new System.Drawing.Point(134, 402);
            this.KoS.Name = "KoS";
            this.KoS.Size = new System.Drawing.Size(160, 21);
            this.KoS.TabIndex = 20;
            // 
            // CompetitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 443);
            this.Controls.Add(this.KoS);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CompetitionForm";
            this.Text = "CompetitionForm";
            this.Load += new System.EventHandler(this.CompetitionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox KoS;
    }
}