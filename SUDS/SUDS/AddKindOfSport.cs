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
    public partial class AddKindOfSport : Form
    {
        public SudsDb db { get; set; }
        string strCategory;
        public AddKindOfSport()
        {
            InitializeComponent();
        }

        private void AddKindOfSport_Load(object sender, EventArgs e)
        {
            
        }

        private void selectCategoryButton_Click(object sender, EventArgs e)
        {
            SelectCategories form = new SelectCategories();
            form.db = db;
            form.button1.Click += (senderS, eS) => {
                strCategory = form.str;
                label3.Text = strCategory;
            };

            form.ShowDialog();

        }
        
        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Replace(" ", "") != "" && strCategory != "")
            {
                Boolean exist = false;
                Category category = null;
                
                
                foreach (Category cat in db.Categories)
                {
                    if (cat.Name.Equals(strCategory))
                        category = cat;
                }
                
                KindOfSport newData = new KindOfSport()
                {
                    NameOfSport = textBox1.Text,
                    Category = category
                };

                foreach (KindOfSport ks in db.KindsOfSport)
                {
                    if (ks.NameOfSport.Equals(newData.NameOfSport))
                    {
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    db.KindsOfSport.Add(newData);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такой вид спорта уже существует.");
                }
            }else
            {
                MessageBox.Show(null, "Сначала заполните поля", "Ошибка" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
