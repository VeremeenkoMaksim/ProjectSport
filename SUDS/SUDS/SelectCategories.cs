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
        public SelectCategories()
        {
            InitializeComponent();
        }

        private void SelectCategories_Load(object sender, EventArgs e)
        {
            db = new SudsDb();
            db.Categories.Load();
            var data = from category in db.Categories
                       select new
                       {
                           Название = category.Name,
                           Тип = category.Type,
                       };
            dataGridView1.DataSource = data.ToList();
        }
    }
}
