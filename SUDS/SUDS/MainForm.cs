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
    public partial class MainForm : Form
    {
        public SudsDb db { get; set; }
        public User user { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new SudsDb();
            Competition comp = new Competition();
            comp = (from Competition in db.Competitions
                    where Competition.Id == 1
                    select Competition).FirstOrDefault<Competition>();
            User judge = new User();
            judge = (from User in db.Users
                     where User.Id == 16
                     select User).FirstOrDefault<User>();
            CompetitionJudges cj = new CompetitionJudges();
            cj.JudgeId = judge.Id;
            cj.CompetitionId = comp.Id;
            db.CompetitionJudges.Add(cj);
            db.SaveChanges();

            Authorization form = new Authorization();
            form.db = db;
            form.ShowDialog();
            user = form.user;
            label1.Text = user.Surname + " " + user.Name + " " + user.Role;
        }

        private void видыСпортаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KindOfSportForm form = new KindOfSportForm();
            form.db = db;
            form.Show();
        }

        private void судьиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JudgeForm form = new JudgeForm();
            form.db = db;
            form.ShowDialog();
        }

        private void организаторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SponsorForm form = new SponsorForm();
            form.db = db;
            form.ShowDialog();
        }

<<<<<<< HEAD
        private void спортсменыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SportsmanForm form = new SportsmanForm();
            form.db = db;
            form.ShowDialog();
        }

        private void соревнованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompetitionForm form = new CompetitionForm();
            //form.db = db;
            form.ShowDialog();
=======
        private void соревнованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompetitionForm form = new CompetitionForm();
            form.db = db;
            form.Show();
>>>>>>> 2766d868190f716148167dbb1a728a90701c992b
        }
    }
}
