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

namespace inter
{
    public partial class NewAccount : Form
    {
      
        public NewAccount()
        {
            InitializeComponent();

        }
        #region esas
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J12R9UI\SQLEXPRESS;Initial Catalog=LoginDb;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            #region esas
            conn.Open();
            com = new SqlCommand("insert into tbl_login (Username,Password) values ('" + txtCreateName.Text.Trim() + "','" + txtCreatPassword.Text.Trim() + "')", conn);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            this.Close();
            conn.Close();
            MessageBox.Show("Success");
            #endregion

        }

    }
}
