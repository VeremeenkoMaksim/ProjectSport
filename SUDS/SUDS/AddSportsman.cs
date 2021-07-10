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
    public partial class AddSportsman : Form
    {
        public SudsDb db { get; set; }
        bool exist;
        public AddSportsman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exist = false;
            if (nameBox.Text.Replace(" ", "") != "" && surnameBox.Text.Replace(" ", "") != "" && WeightBox.Text.Replace(" ", "") != "" && HeightBox.Text.Replace(" ", "") != "")
            {
                Sportsman newData = new Sportsman();
                newData.Name = nameBox.Text;
                newData.Surname = surnameBox.Text;
                newData.DateOfBirth = dateOfBirthBox.Value;
                newData.Weight = Convert.ToInt32(WeightBox.Text);
                newData.Height = Convert.ToInt32(HeightBox.Text);


                foreach (Sportsman s in db.Sportsmen)
                {
                    if (s.Name.Equals(newData.Name) && s.Surname.Equals(newData.Surname))
                    {
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    db.Sportsmen.Add(newData);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(null, "Такой судья уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(null, "Сначала заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
