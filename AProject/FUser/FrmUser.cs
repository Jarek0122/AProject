using AProject.CUser;
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

namespace AProject.FUser
{
    public partial class FrmUser : Form
    {
        private SqlDataAdapter _adapter;
        private int _position;
        private SqlCommandBuilder _builder;
        public FrmUser()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

        }

        private void FMembers_Load(object sender, EventArgs e)
        {
            displayBySql("SELECT * FROM tUser");

        }

        private void displayBySql(string sql)
        {
            SqlConnection con = new SqlConnection();
            //con.ConnectionString = CSQL.LocalConnectionString;
            con.ConnectionString = CSQL.RemoteConnectionString;
            //con.ConnectionString = "Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False";
            con.Open();

            _adapter = new SqlDataAdapter(sql, con);
            _builder = new SqlCommandBuilder(_adapter);

            _adapter.SelectCommand.Parameters.Add(
                new SqlParameter("K_KEYWORD", "%" + (object)txtKeyword.Text + "%"));

            DataSet ds = new DataSet();
            _adapter.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmUserEditor f = new FrmUserEditor();
            f.title = "新增會員資料";
            f.ShowDialog();
            if (f.isok == DialogResult.OK) 
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr["fUserEmail"] = f.users.fEmail;
                dr["fUserPassword"] = f.users.fPassword;
                dr["fUserName"] = f.users.fName;
                dr["fUserPhone"] = f.users.fPhone;
                dr["fUserGender"] = f.users.fGender;
                dr["fUserAddress"] = f.users.fAddress;
                dr["fUserBirthdate"] = f.users.fBirthdate;
                dr["fUserState"] = f.users.fState;
                dr["fUserImage"] = f.users.fImage;

                dt.Rows.Add(dr);
            }
        }

        private void FrmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            dr.Delete();
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            CUsers u = new CUsers();
            u.fEmail = dr["fUserEmail"].ToString();
            u.fPassword = dr["fUserPassword"].ToString();
            u.fName = dr["fUserName"].ToString();
            u.fPhone = dr["fUserPhone"].ToString();
            u.fGender = dr["fUserGender"].ToString();
            u.fAddress = dr["fUserAddress"].ToString();
            u.fBirthdate = dr["fUserBirthdate"].ToString();
            u.fState = dr["fUserState"].ToString();
            if (dr["fUserImage"] != DBNull.Value)
                u.fImage = (byte[])dr["fUserImage"];

            FrmUserEditor f = new FrmUserEditor();
            f.title = "修改會員資料";
            f.users = u;
            f.ShowDialog();
            if (f.isok == DialogResult.OK)
            {
                dr["fUserEmail"] = f.users.fEmail;
                dr["fUserPassword"] = f.users.fPassword;
                dr["fUserName"] = f.users.fName;
                dr["fUserPhone"] = f.users.fPhone;
                dr["fUserGender"] = f.users.fGender;
                dr["fUserAddress"] = f.users.fAddress;
                dr["fUserBirthdate"] = f.users.fBirthdate;
                dr["fUserState"] = f.users.fState;
                dr["fUserImage"] = f.users.fImage;
            }

        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void FrmUser_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.Columns[0].Width = 0;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[1].HeaderText = "會員信箱";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[2].HeaderText = "會員密碼";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[3].HeaderText = "會員姓名";
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[4].HeaderText = "會員電話";
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[5].HeaderText = "會員性別";
            dataGridView1.Columns[6].Width = 350;
            dataGridView1.Columns[6].HeaderText = "會員地址";
            dataGridView1.Columns[7].Width = 120;
            dataGridView1.Columns[7].HeaderText = "會員生日";
            dataGridView1.Columns[8].Width = 80;
            dataGridView1.Columns[8].HeaderText = "會員狀態";
            dataGridView1.Columns[9].Width = 120;
            dataGridView1.Columns[9].HeaderText = "會員照片";
            resetGridStyle();
        }

        private void resetGridStyle()
        {

            bool isColorChanged = false;
            int count = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                count++;
                isColorChanged = !isColorChanged;
                r.DefaultCellStyle.BackColor = Color.White;
                if (isColorChanged)
                    r.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 13);
                r.Height = 40;
                r.HeaderCell.Value = count.ToString();
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tUser";
            sql += " WHERE fUserName LIKE @K_KEYWORD";
            sql += " OR fUserPhone LIKE @K_KEYWORD";
            sql += " OR fUserEmail LIKE @K_KEYWORD";
            sql += " OR fUserAddress LIKE @K_KEYWORD";

            displayBySql(sql);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            displayBySql("SELECT * FROM tUser");
        }
    }
}
