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
    public partial class CompetitionForm : Form
    {
        public SudsDb db { get; set; }
        public CompetitionForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddCompetition form = new AddCompetition();
            form.db = db;
            form.Add.Click += (senderS, eS) =>
            {
                loadData();
            };
            form.ShowDialog();
        }

        private void CompetitionForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            var data = from Competition in db.Competitions
                       select new
                       {
                           Id = Competition.Id,
                           Дата = Competition.Date,
                           Вид_спорта = Competition.KindOfSport.NameOfSport
                       };
            dataGridView1.DataSource = data.ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                EditCompetition form = new EditCompetition();
                form.db = db;
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                Competition competition = (from Competition in db.Competitions
                                  where Competition.Id == id
                                  select Competition).FirstOrDefault<Competition>();
                form.competition = competition;
                form.ShowDialog();
                loadData();
            }
            else
            {
                MessageBox.Show("Выделите строку с соревнованием!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранное соревнование?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    Competition competition = (from Competition in db.Competitions
                                               where Competition.Id == id
                                               select Competition).FirstOrDefault<Competition>();
                    db.Competitions.Remove(competition);
                    db.SaveChanges();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Выделите строку с соревнованием!");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }
    }
}
