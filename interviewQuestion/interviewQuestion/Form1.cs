using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interviewQuestion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-J12R9UI\\SQLEXPRESS;Initial Catalog=UserLogin;Integrated Security=True";

        public object SqlComand { get; private set; }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State==System.Data.ConnectionState.Open)
            {
                string q = "insert into Users(Id,Name,Password) values('" + txtFullName.Text.ToString() + "'+'" + txtPassword.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection made Succesfully");
            }
        }
    }
}
