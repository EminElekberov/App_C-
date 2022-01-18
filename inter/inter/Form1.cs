using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace inter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-J12R9UI\SQLEXPRESS;Initial Catalog=LoginDb;Integrated Security=True");
            string query = "select * from tbl_login where Username='" + txtFullName.Text.Trim() + "'and Password='" + txtPassword.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count==1)
            {
                frmMain frm = new frmMain();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Password or name is wrong");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
