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
    public partial class SelectCategories : Form
    {
        SudsDb db;
        public string[] str;
        public SelectCategories()
        {
            InitializeComponent();
        }

        private void SelectCategories_Load(object sender, EventArgs e)
        {
            db = new SudsDb();
            db.Categories.Load();
            foreach (Category cat in db.Categories) {
                checkedListBox1.Items.Add(cat.Name);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = new string[checkedListBox1.CheckedItems.Count];
            int i = 0;
            foreach (CheckedListBox.CheckedItemCollection ch in checkedListBox1.CheckedItems) {
                str[i]= ch.ToString();
                i++;
            }
        }
    }
}
