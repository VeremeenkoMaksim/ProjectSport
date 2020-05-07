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
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void видыСпортаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KindOfSportForm form = new KindOfSportForm();
            form.Show();
        }

        private void судьиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JudgeForm form = new JudgeForm();
            form.Show();
        }
    }
}
