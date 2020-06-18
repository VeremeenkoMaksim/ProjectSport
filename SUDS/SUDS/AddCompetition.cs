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
    public partial class AddCompetition : Form
    {
        public SudsDb db { get; set; }
        public string judge;
        public string sponsor;
        public string kindofsport;

        public AddCompetition()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (KoS.SelectedItem != null || Jud.SelectedItem != null || Spo.SelectedItem != null)
            {
                Boolean exist = false;
                judge = Jud.SelectedItem.ToString();
                sponsor = Spo.SelectedItem.ToString();
                kindofsport = KoS.SelectedItem.ToString();
                Competition newData = new Competition()
                {
                    Date = dateTimePicker1.Value,
                    /*Judges = (from Competition in db.Competitions where Competition.Judges == judge select Competition).FirstOrDefault<Competition>(),
                    Sponsor = (from Competition in db.Competitions where Competition.Sponsor == sponsor select Competition).FirstOrDefault<Competition>(),
                    KindOfSport = (from Competition in db.Competitions where Competition.KindOfSport == kindofsport select Competition).FirstOrDefault<Competition>()
                    */
                };
                foreach (Competition com in db.Competitions)
                {
                    if (com.Date.Equals(newData.Date))
                    {
                        if (com.Judges.Equals(newData.Judges))
                        {
                            if (com.Sponsor.Equals(newData.Sponsor))
                            {
                                if (com.KindOfSport.Equals(newData.KindOfSport))
                                {
                                    exist = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (!exist)
                {
                    db.Competitions.Add(newData);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такое соревнование уже существует.");
                }
            }
            else
            {
                MessageBox.Show(null, "Сначала заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCompetition_Load(object sender, EventArgs e)
        {
            db.KindsOfSport.Load();
            db.Users.Load();
            foreach (KindOfSport kos in db.KindsOfSport)
            {
                KoS.Items.Add(kos.NameOfSport);
            }
            foreach (User us in db.Users)
            {
                if (us.Role == 1)
                    Jud.Items.Add(us.Name);
                else if (us.Role == 0)
                    Spo.Items.Add(us.Name);
            }
        }
    }
}
