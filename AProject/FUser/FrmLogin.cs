using AProject.CUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AProject.FUser
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            //con.ConnectionString = CSQL.LocalConnectionString;
            con.ConnectionString = CSQL.RemoteConnectionString;
            //con.ConnectionString = @"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tUser WHERE fUserEmail=@K_FEMAIL AND fUserPassword=@K_FPASSWORD";
            cmd.Parameters.Add(new SqlParameter("K_FEMAIL", (object)fbEmail.fieldValue));
            cmd.Parameters.Add(new SqlParameter("K_FPASSWORD", (object)fbPassword.fieldValue));
            SqlDataReader reader = cmd.ExecuteReader();

            string msg = "";
            if (!reader.Read())
                msg = "帳號與密碼不符";
            con.Close();

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
            }
            else
                Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
