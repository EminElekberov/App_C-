using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestuarntApi
{
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void Area_Load(object sender, EventArgs e)
        {

        }

        private void salon1Btn_Click(object sender, EventArgs e)
        {
            Salon1 salon1 = new Salon1();
            salon1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void salon2Btn_Click(object sender, EventArgs e)
        {
            Salon2 s2 = new Salon2();
            s2.ShowDialog();
        }

        private void TerasBtn_Click(object sender, EventArgs e)
        {
            Salon2 s2 = new Salon2();
            s2.ShowDialog();
        }
    }
}
