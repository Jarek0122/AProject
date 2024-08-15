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
using AProject.CAd;
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
                if(_CAD == null)
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
                LBad.Text =_CAD.fAdName;
                Lbuser.Text = _CAD.fUserName;
                SelectAd.Text = _CAD.fAdType;
                LbImagepath.Text = _CAD.fImagePath;
                LbNet.Text = _CAD.fLink;


            }
        }
        
        
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ad;Integrated Security=True;");
        SqlConnection con = new SqlConnection(@"Data Source = 192.168.35.57,1433; Initial Catalog = Aproject; User ID = Ray; Encrypt=False;");
        private void populate()
        {
            
            con.Open();
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
            con.Open();
            string query = "select *from tAdvertisement where fAdType = '"+Choosetype.SelectedItem.ToString()+"'" ;
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
            FAd.FrmAddAD newForm = new FAd.FrmAddAD();
            newForm.Show();

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
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LBad.Text = AdDGV.SelectedRows[0].Cells[0].Value.ToString();
            Lbuser.Text=AdDGV.SelectedRows[0].Cells[1].Value.ToString();
            SelectAd.SelectedItem= AdDGV.SelectedRows[0].Cells[2].Value.ToString();
            LbImagepath.Text= AdDGV.SelectedRows[0].Cells[3].Value.ToString();
            LbNet.Text= AdDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (LBad.Text == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(AdDGV.SelectedRows[0].Cells[0].Value.ToString());
                
            
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
                MessageBox.Show("廣告上傳完成");
                con.Close();
                
                
            }
            




        }

        private void Choosetype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();

        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            
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
            if (key == 0)
            {
                MessageBox.Show("欄位不可為空");
            }

            else
            {
                try
                {
                    con.Open();

                    string query = "delete from Advertisement where AdvertisementId ="+key+""; 
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("廣告移除成功");
                    con.Close();
                    populate();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }
    }
}
