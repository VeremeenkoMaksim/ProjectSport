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

        public SudsDb db { get; set; }
        public KindOfSportForm( )
        {
            InitializeComponent();
        }

        private void KindOfSportForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddKindOfSport form = new AddKindOfSport();
            form.db = db;
            form.Add.Click += (senderS, eS) =>
            {
                loadData();
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
                EditKindOfSport form = new EditKindOfSport();
                form.db = db;
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

               KindOfSport ks = (from KindOfSport in db.KindsOfSport
                           where KindOfSport.Id == id
                           select KindOfSport).FirstOrDefault<KindOfSport>();
                Category cat = (from KindOfSport in db.KindsOfSport
                                where KindOfSport.Id == id
                                select KindOfSport.Category).FirstOrDefault<Category>();
                form.cat = cat;
                form.ks = ks;
                form.ShowDialog();
                loadData();
            }
            else {
                MessageBox.Show("Выделите строку с видом спорта");
            }
        }
        private void loadData() {
            var data = from kindOfSport in db.KindsOfSport
                       select new
                       {
                           Id = kindOfSport.Id,
                           Название = kindOfSport.NameOfSport,
                           Категория = kindOfSport.Category.Name,
                       };
            dataGridView1.DataSource = data.ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный вид спорта?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    KindOfSport ks = (from KindOfSport in db.KindsOfSport
                                      where KindOfSport.Id == id
                                      select KindOfSport).FirstOrDefault<KindOfSport>();
                    db.KindsOfSport.Remove(ks);
                    db.SaveChanges();
                    loadData();
                }
            }
            else {
                MessageBox.Show("Выделите строку с видом спорта");
            }
        }
    }
}
