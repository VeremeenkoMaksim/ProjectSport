using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUDS
{
    public partial class KindOfSportForm : Form
    {
        public SudsDb db { get; set;}
        public KindOfSportForm()
        {
            InitializeComponent();
        }

        private void KindOfSportForm_Load(object sender, EventArgs e)
        {
            var data = from kindOfSport in db.KindsOfSport
                       select new
                       {
                           Название = kindOfSport.NameOfSport,
                           Категория = kindOfSport.Category.Name,
                       };
            dataGridView1.DataSource = data.ToList();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddKindOfSport form = new AddKindOfSport();
            form.Add.Click += (senderS, eS) =>
            {
                var data = from kindOfSport in db.KindsOfSport
                           select new
                           {
                               Название = kindOfSport.NameOfSport,
                               Категория = kindOfSport.Category.Name,
                           };
                dataGridView1.DataSource = data.ToList();
            };
            form.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                
                EditKindOfSport form = new EditKindOfSport(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                form.Show();

            }
        }
    }
}
