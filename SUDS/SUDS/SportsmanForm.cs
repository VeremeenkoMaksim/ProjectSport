using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUDS
{
    public partial class SportsmanForm : Form
    {
        public SudsDb db { get; set; }
        public SportsmanForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SportsmanForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            var data = from Sportsman in db.Sportsmen
                       select new
                       {
                           Id = Sportsman.Id,
                           Имя = Sportsman.Name,
                           Фамилия = Sportsman.Surname,
                           Вес = Sportsman.Weight,
                           Рост = Sportsman.Height,
                           Дата_рождения = Sportsman.DateOfBirth

                       };
            dataGridView1.DataSource = data.ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddSportsman form = new AddSportsman();
            form.db = db;
            form.ShowDialog();
            loadData();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditSportsman form = new EditSportsman();
            form.db = db;

            if(dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Sportsman s = (from Sportsman in db.Sportsmen where Sportsman.Id == id select Sportsman).FirstOrDefault<Sportsman>();
                form.s = s;
                form.ShowDialog();
                loadData();
            }
            else {
                MessageBox.Show("Выделите строку с судьей");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранного судью?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    Sportsman s = (from Sportsman in db.Sportsmen
                               where Sportsman.Id == id
                               select Sportsman).FirstOrDefault<Sportsman>();
                    db.Sportsmen.Remove(s);
                    db.SaveChanges();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Выделите строку с видом спорта");
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedRows.Count;
            for (int i = 0; i < count; i++) {
                dataGridView1.SelectedRows[0].Selected = false;
            }
            
            string name = searchBox.Text.Split(' ')[0];
            string surname = searchBox.Text.Split(' ')[1];
            Sportsman s = (from Sportsman in db.Sportsmen
                           where Sportsman.Surname == surname && Sportsman.Name == name
                           select Sportsman).FirstOrDefault<Sportsman>();

            for (int i = 0; i < dataGridView1.RowCount; i++)
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == s.Id)
                    dataGridView1.Rows[i].Selected = true;

            //Sportsman s = (from Sportsman in db.Sportsmen
            //               where Sportsman.Surname == searchBox.Text
            //               select Sportsman).FirstOrDefault<Sportsman>();

            //while (s != null)
            //{
            //    for (int i = 0; i < dataGridView1.RowCount; i++)
            //        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == s.Id)
            //            dataGridView1.Rows[i].Selected = true;
            //    s = (from Sportsman in db.Sportsmen
            //                   where Sportsman.Surname == searchBox.Text
            //                   select Sportsman).FirstOrDefault<Sportsman>();
            //}


            //    s = (from Sportsman in db.Sportsmen
            //         where Sportsman.Name == searchBox.Text
            //         select Sportsman).FirstOrDefault<Sportsman>();


            //while (s != null) {
            //    for (int i = 0; i < dataGridView1.RowCount; i++)
            //        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == s.Id)
            //            dataGridView1.Rows[i].Selected = true;
            //    s = (from Sportsman in db.Sportsmen
            //         where Sportsman.Name == searchBox.Text
            //         select Sportsman).FirstOrDefault<Sportsman>();

            //}
            //    if(dataGridView1.SelectedRows.Count == 0) MessageBox.Show("Спортсмен не найден");
        }
    }
}
