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
    public partial class Login : Form
    {
         List<Group> groups = new List<Group>();
        private ComboBox _cmbAdd;
        private DataGridView _dgvAddeats;

        public Login(List<Group> grps, ComboBox cmb, DataGridView dgv)
        {
            InitializeComponent();
            this.groups = grps;
            _cmbAdd = cmb;
            _dgvAddeats = dgv;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "User Name";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox1.Text = "User Password";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "emin";
            string pass = "emin1234";
            if ((textBox1.Text==user) && (textBox2.Text==pass))
            {
                MessageBox.Show("Welcome Menecer");
                this.Hide();
                AddMenuDishes f1 = new AddMenuDishes(groups, _cmbAdd, _dgvAddeats);
                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("wrong user name or password", "Error");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
