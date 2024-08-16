using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using AProject.CMatch;

namespace AProject.FAd
{
    public partial class FrmAdverTisement : Form
    {
        private CAD _CAD;
        public FrmAdverTisement()
        {
            InitializeComponent();
            populate();
        }
        public CAD CAD
        {
            get
            {
                if (_CAD == null)
                    _CAD = new CAD();
                _CAD.fAdName = LBad.Text;
                _CAD.fUserName = Lbuser.Text;
                _CAD.fAdType = SelectAd.Text;
                _CAD.fImagePath = LbImagepath.Text;
                _CAD.fLink = LbNet.Text;



                return _CAD;
            }
            set
            {

                _CAD = value;
                LBad.Text = _CAD.fAdName;
                Lbuser.Text = _CAD.fUserName;
                SelectAd.Text = _CAD.fAdType;
                LbImagepath.Text = _CAD.fImagePath;
                LbNet.Text = _CAD.fLink;


            }
        }


        //SqlConnection con = new SqlConnection(@"Data Source = 192.168.35.57,1433; Initial Catalog = Aproject; User ID = Ray; Encrypt=False;");
        private void populate()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = 192.168.35.57,1433; Initial Catalog = Aproject; User ID = Ray; Encrypt=False;";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;





            string query = "select *from tAdvertisement ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);
            AdDGV.DataSource = ds.Tables[0];
            con.Close();


        }
        private void Filter()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = 192.168.35.57,1433; Initial Catalog = Aproject; User ID = Ray; Encrypt=False;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;






            string query = "select *from tAdvertisement where fAdType = '" + Choosetype.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AdDGV.DataSource = ds.Tables[0];
            con.Close();



        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void adadd_Click_1(object sender, EventArgs e)
        {


        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 廣告名稱_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private string key = null;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AdDGV.SelectedRows.Count > 0)
            {
                var selectedRow = AdDGV.SelectedRows[0];

                if (selectedRow.Cells[0].Value != null)
                {
                    LBad.Text = selectedRow.Cells[0].Value.ToString();
                    key = LBad.Text;
                }

                if (selectedRow.Cells[1].Value != null)
                    Lbuser.Text = selectedRow.Cells[1].Value.ToString();

                if (selectedRow.Cells[2].Value != null)
                    SelectAd.SelectedItem = selectedRow.Cells[2].Value.ToString();

                if (selectedRow.Cells[3].Value != null)
                    LbImagepath.Text = selectedRow.Cells[3].Value.ToString();

                if (selectedRow.Cells[4].Value != null)
                    LbNet.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void FrmAdverTisement_Load(object sender, EventArgs e)
        {

        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            if (LBad.Text == "" || Lbuser.Text == "" || SelectAd.SelectedIndex == -1 || LbImagepath.Text == "" || LbNet.Text == "")
            {
                MessageBox.Show("欄位不可為空");
            }
            else
            {
                DataTable dt = AdDGV.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr["fAdName"] = LBad.Text;
                dr["fUserName"] = Lbuser.Text;
                dr["fAdType"] = SelectAd.Text;
                dr["fImagePath"] = LbImagepath.Text;
                dr["fLink"] = LbNet;
                dt.Rows.Add(dr);
                create(CAD);
                MessageBox.Show("廣告上架成功");



            }









        }

        private void create(CAD p)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = 192.168.35.57,1433; Initial Catalog = Aproject; User ID = Ray; Encrypt=False;";
            con.Open();

            String sql = "INSERT INTO tAdvertisement( fAdName, fUserName, fAdType, fImagePath,fLink) VALUES( @fAdName, @fUserName, @fAdType, @fImagePath, @fLink)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@fAdName", p.fAdName);
            cmd.Parameters.AddWithValue("@fUserName", p.fUserName);
            cmd.Parameters.AddWithValue("@fAdType", p.fAdType);
            cmd.Parameters.AddWithValue("@fImagePath", p.fImagePath);
            cmd.Parameters.AddWithValue("@fLink", p.fLink);
            cmd.ExecuteNonQuery();







            cmd.Connection = con;




            con.Close();
        }



        private void Choosetype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();

        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            
            populate();
            Choosetype.SelectedIndex = -1;
        }
        private void reset()
        {
            LBad.Text = "";
            Lbuser.Text = "";
            SelectAd.SelectedIndex = -1;
            LbImagepath.Text = "";
            LbNet.Text = "";
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();

        }



        private void btndelete_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("請選擇要刪除的廣告");
                return;
            }

            var result = MessageBox.Show("確定要刪除選中的廣告嗎？", "刪除確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = 192.168.35.57,1433; Initial Catalog = Aproject; User ID = Ray; Encrypt=False;"))
                {
                    con.Open();

                    string query = "DELETE FROM tAdvertisement WHERE fAdName = @fAdName";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fAdName", key);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("廣告刪除成功");
                    }
                    else
                    {
                        MessageBox.Show("未找到要刪除的廣告");
                    }

                    populate();
                    reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
            }
        }



        private void Btnwrite_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("請選擇要更新的廣告");
                return;
            }

            if (string.IsNullOrEmpty(LBad.Text) || string.IsNullOrEmpty(Lbuser.Text) ||
                SelectAd.SelectedIndex == -1 || string.IsNullOrEmpty(LbImagepath.Text) ||
                string.IsNullOrEmpty(LbNet.Text))
            {
                MessageBox.Show("所有欄位都必須填寫");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = 192.168.35.57,1433; Initial Catalog = Aproject; User ID = Ray; Encrypt=False;"))
                {
                    con.Open();

                    string query = "UPDATE tAdvertisement SET fAdName = @fAdName, fUserName = @fUserName, fAdType = @fAdType, fImagePath = @fImagePath, fLink = @fLink WHERE fAdName = @OldfAdName";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fAdName", LBad.Text);
                    cmd.Parameters.AddWithValue("@fUserName", Lbuser.Text);
                    cmd.Parameters.AddWithValue("@fAdType", SelectAd.Text);
                    cmd.Parameters.AddWithValue("@fImagePath", LbImagepath.Text);
                    cmd.Parameters.AddWithValue("@fLink", LbNet.Text);
                    cmd.Parameters.AddWithValue("@OldfAdName", key); 
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("廣告更新成功");
                    }
                    else
                    {
                        MessageBox.Show("更新失敗，未找到要更新的廣告");
                    }

                    populate(); 
                    reset(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
            }
        }
    }
}

       
    
