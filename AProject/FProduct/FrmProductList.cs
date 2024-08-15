using AProject.CProduct;
using AProject.FProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AProject.Views
{
    public partial class FrmProductList : Form
    {
        private SqlDataAdapter _adapter;
        public FrmProductList()
        {
            InitializeComponent();
        }
        private int _position=-1;
        private SqlCommandBuilder _builder;
        private void displayBySql(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False";
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
        private void FrmProductList_Load(object sender, EventArgs e)
        {
            displayBySql("SELECT fProductId,fProdName,fProdDescription,fProdStock,fProdPrice,fProdImage" +
                          "\r\nFROM tProduct");
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmProductEditor f=new FrmProductEditor();
            f.title = " 新增商品";
            f.ShowDialog();
            if (f.isOK == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr["fProdName"]=f.product.fProdName;
                dr["fProdDescription"]=f.product.fProdDescription;
                dr["fProdPrice"]=f.product.fProdPrice;
                dr["fProdImage"]=f.product.fProdImage;
                dt.Rows.Add(dr);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            CProd m = new CProd();
            m.fProdPrice = (decimal)dr["fProdPrice"];
            m.fProdName = dr["fProdName"].ToString();
            m.fProdDescription=dr["fProdDescription"].ToString();
            if (dr["fProdImage"] != DBNull.Value)
                m.fProdImage = (byte[])dr["fProdImage"];
            //if (dr["fProdId"] != DBNull.Value)
            //    m.fProdId = (int)dr["fProdId"];

            FrmProductEditor f= new FrmProductEditor();
            f.title = " 修改商品";
            f.product = m;
            f.ShowDialog();
            if (f.isOK == DialogResult.OK)
            {
                dr["fProdName"] = f.product.fProdName;
                dr["fProdDescription"] = f.product.fProdDescription;
                dr["fProdPrice"] = f.product.fProdPrice;
                dr["fProdImage"] = f.product.fProdImage;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt=dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            dr.Delete();
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT fProductId,fProdName,fProdDescription,fProdStock,fProdPrice,fProdImage \r\nFROM tProduct";
            sql += " WHERE fProdName LIKE @K_KEYWORD";

            displayBySql(sql);
        }

        private void FrmProductList_FormClosed(object sender, FormClosedEventArgs e)
        {
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }

        private void FrmProductList_Resize(object sender, EventArgs e)
        {
           
        }

        private void FrmProductList_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }

        private void resetGridStyle()
        {
            dataGridView1.Columns[0].HeaderText = "編號";
            dataGridView1.Columns[1].HeaderText = "架上數量";
            dataGridView1.Columns[2].HeaderText = "商品描述";
            dataGridView1.Columns[3].HeaderText = "商品庫存";
            dataGridView1.Columns[4].HeaderText = "商品售價";
            dataGridView1.Columns[5].HeaderText = "商品照片";
            dataGridView1.Columns[0].Width = 40;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql = "SELECT fProductId,fProdName,fProdDescription,fProdStock,fProdPrice,fProdImage \r\nFROM tProduct";
            sql += " WHERE fProdName LIKE @K_KEYWORD";

            displayBySql(sql);
        }
    }
}
