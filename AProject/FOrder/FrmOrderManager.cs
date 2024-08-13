using AProject.Model;
using AProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AProject.FOrder
{
    public partial class FrmOrderManager : Form
    {
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _builder;
        private int _position = -1;
        public FrmOrderManager()
        {
            InitializeComponent();
        }


        private void FrmOrderManager_Load(object sender, EventArgs e)
        {
            displayBySql(@" SELECT
                                o.fOrderId,
                                o.fUserId,
                                o.fOrderDate,
                                o.fOrderStatus,
                                od.fProductId,
                                od.fQuantity,
                                o.fPromotionId,
                                od.fPrice,
                                o.fPaymentStatus,
                                o.fShippingStatus,
                                o.fServiceStatus,
                                o.fPaymentInfo,
                                o.fInvoiceInfo,
                                o.fRecepientName,
                                o.fRecepientAddress,
                                o.fRecepientPhone,
                                o.fRecepientEmail,
                                o.fOrderRemarks,
                                o.fShippingInfo,
                                o.fReturnInfo
                            FROM tOrder o
                            JOIN tOrderDetail od ON o.fOrderId = od.fOrderId",dataGridView1);

            displayBySql(@" SELECT * FROM tDonation d", dataGridView2);

            displayBySql(@" SELECT
                                od.fOrderDetailId,
                                o.fUserId,
                                o.fOrderId,
                                od.fProductId,
                                od.fReviewDate,
                                od.fReviewScore,
                                od.fProductReview
                            FROM tOrder o
                            JOIN tOrderDetail od ON o.fOrderId = od.fOrderId", dataGridView3);

        }

        private void displayBySql(string sql, DataGridView dataGridView)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False";
            con.Open();

            _adapter = new SqlDataAdapter(sql, con);
            _builder = new SqlCommandBuilder(_adapter);

            _adapter.SelectCommand.Parameters.Add(
                new SqlParameter("K_KEYWORD", "%" + (object)txtOrder.Text + "%"));
            _adapter.SelectCommand.Parameters.Add(
                new SqlParameter("K_KEYWORD", "%" + (object)txtReview.Text + "%"));
            _adapter.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD", "%" + (object)txtDonate.Text + "%"));

            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];

            con.Close();
        }

        private void btnOrderRefresh_Click(object sender, EventArgs e)
        {
            displayBySql(@" SELECT
                                o.fOrderId,
                                o.fUserId,
                                o.fOrderDate,
                                o.fOrderStatus,
                                od.fProductId,
                                od.fQuantity,
                                o.fPromotionId,
                                od.fPrice,
                                o.fPaymentStatus,
                                o.fShippingStatus,
                                o.fServiceStatus,
                                o.fPaymentInfo,
                                o.fInvoiceInfo,
                                o.fRecepientName,
                                o.fRecepientAddress,
                                o.fRecepientPhone,
                                o.fRecepientEmail,
                                o.fOrderRemarks,
                                o.fShippingInfo,
                                o.fReturnInfo
                            FROM tOrder o
                            JOIN tOrderDetail od ON o.fOrderId = od.fOrderId",dataGridView1);
        }

        private void btnOrderCreate_Click(object sender, EventArgs e)
        {
            //FrmProductEditor f = new FrmProductEditor();
            //f.titleIcon = btnCreate.Image;
            //f.title = "新增電影作業";
            //f.ShowDialog();
            //if (f.isOk == DialogResult.OK)
            //{
            //    DataTable dt = dataGridView1.DataSource as DataTable;
            //    DataRow dr = dt.NewRow();
            //    dr["fName"] = f.movie.fName;
            //    dr["fQty"] = f.movie.fQty;
            //    dr["fCost"] = f.movie.fCost;
            //    dr["fPrice"] = f.movie.fPrice;
            //    dr["fImage"] = f.movie.fImage;
            //    dt.Rows.Add(dr);
            //}
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            dr.Delete();
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }

        private void btnOrderEdit_Click(object sender, EventArgs e)
        {
            //DataTable dt = dataGridView1.DataSource as DataTable;
            //DataRow dr = dt.Rows[_position];
            //COrder o = new COrder();
            //if (dr["fOrderId"] != DBNull.Value)
            //    o.fOrderId = (int)dr["fOrderId"];
            //if (dr["fUserId"] != DBNull.Value)
            //    o.fUserId = (int)dr["fUserId"];
            //if (dr["fPromotionId"] != DBNull.Value)
            //    o.fPromotionId = (int)dr["fPromotionId"];
            //o.fOrderDate = (string)dr["fOrderDate"];
            //o.fOrderStatus = (string)dr["fOrderStatus"];
            //o.fPaymentStatus = (bool)dr["fPaymentStatus"];
            //o.fShippingStatus = (bool)dr["fShippingStatus"];
            //o.fServiceStatus = (bool)dr["fServiceStatus"];
            //o.fPaymentInfo = (string)dr["fPaymentInfo"];
            //o.fInvoiceInfo = (string)dr["fInvoiceInfo"];
            //o.fRecepientName = (string)dr["fRecepientName"];
            //o.fRecepientAddress = (string)dr["fRecepientAddress"];
            //o.fRecepientPhone = (string)dr["fRecepientPhone"];
            //o.fRecepientEmail = (string)dr["fRecepientEmail"];
            //o.fOrderRemarks = (string)dr["fOrderRemarks"];
            //o.fShippingInfo = (string)dr["fShippinginfo"];
            //o.fReturnInfo = (string)dr["fReturnInfo"];

            //COrderDetail od = new COrderDetail();
            //if (dr["fProductId"] != DBNull.Value)
            //    od.fProductId = (int)dr["fProductId"];
            //od.fQuantity = (int)dr["fQuantity"];
            //od.fPrice = (decimal)dr["fPrice"];




            //FrmProductEditor f = new FrmProductEditor();
            //f.titleIcon = btnEdit.Image;
            //f.title = "編輯電影作業";
            //f.movie = m;
            //f.ShowDialog();
            //if (f.isOk == DialogResult.OK)
            //{
            //    dr["fName"] = f.movie.fName;
            //    dr["fCost"] = f.movie.fCost;
            //    dr["fQty"] = f.movie.fQty;
            //    dr["fPrice"] = f.movie.fPrice;
            //    dr["fImage"] = f.movie.fImage;
            //}
        }

        private void btnOrderRead_Click(object sender, EventArgs e)
        {
            //string sql = "SELECT o.fOrderId,
            //    o.fUserId,
            //    o.fOrderDate,
            //    o.fOrderStatus,
            //    od.fProductId,
            //    od.fQuantity,
            //    o.fPromotionId,
            //    od.fPrice,
            //    o.fPaymentStatus,
            //    o.fShippingStatus,
            //    o.fServiceStatus,
            //    o.fPaymentInfo,
            //    o.fInvoiceInfo,
            //    o.fRecepientName,
            //    o.fRecepientAddress,
            //    o.fRecepientPhone,
            //    o.fRecepientEmail,
            //    o.fOrderRemarks,
            //    o.fShippingInfo,
            //    o.fReturnInfo
            //FROM tOrder o
            //JOIN tOrderDetail od ON o.fOrderId = od.fOrderId",dataGridView1);
            //sql += " WHERE o.fRecepientEmail LIKE @K_KEYWORD";

            //displayBySql(sql);
        }

        private void btnDonateRefresh_Click(object sender, EventArgs e)
        {
            displayBySql(@" SELECT * FROM tDonation d", dataGridView2);
        }

        private void btnDonateCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnDonateDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView2.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            dr.Delete();
            _adapter.Update(dataGridView2.DataSource as DataTable);
        }

        private void btnDonateEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDonateRead_Click(object sender, EventArgs e)
        {

        }

        private void btnReviewRefresh_Click(object sender, EventArgs e)
        {
            displayBySql(@" SELECT
                                od.fOrderDetailId,
                                o.fUserId,
                                o.fOrderId,
                                od.fProductId,
                                od.fReviewDate,
                                od.fReviewScore,
                                od.fProductReview
                            FROM tOrder o
                            JOIN tOrderDetail od ON o.fOrderId = od.fOrderId", dataGridView3);
        }

        private void btnReviewCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnReviewDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView3.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            dr.Delete();
            _adapter.Update(dataGridView3.DataSource as DataTable);
        }

        private void btnReviewEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnReviewRead_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void dataGridView3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }


        private void FrmOrderManager_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }

        private void resetGridStyle()
        {
            bool isColorChanged = false;
            int count = 0;

            dataGridView1.Columns[0].Width = 0;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].HeaderText = "會員編號";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].HeaderText = "訂單日期";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[3].HeaderText = "訂單狀態";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[4].HeaderText = "商品";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[5].HeaderText = "數量";
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[6].HeaderText = "折扣";
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[7].HeaderText = "小計";
            dataGridView1.Columns[8].Width = 100;
            dataGridView1.Columns[8].HeaderText = "付款狀態";
            dataGridView1.Columns[9].Width = 100;
            dataGridView1.Columns[9].HeaderText = "配送狀態";
            dataGridView1.Columns[10].Width = 100;
            dataGridView1.Columns[10].HeaderText = "服務狀態"; //可以是空值?
            dataGridView1.Columns[11].Width = 100;
            dataGridView1.Columns[11].HeaderText = "付款資訊";
            dataGridView1.Columns[12].Width = 100;
            dataGridView1.Columns[12].HeaderText = "發票資訊";
            dataGridView1.Columns[13].Width = 100;
            dataGridView1.Columns[13].HeaderText = "收件人姓名";
            dataGridView1.Columns[14].Width = 100;
            dataGridView1.Columns[14].HeaderText = "收件人地址";
            dataGridView1.Columns[15].Width = 100;
            dataGridView1.Columns[15].HeaderText = "收件人電話";
            dataGridView1.Columns[16].Width = 100;
            dataGridView1.Columns[16].HeaderText = "收件人信箱";
            dataGridView1.Columns[17].Width = 100;
            dataGridView1.Columns[17].HeaderText = "訂單備註";
            dataGridView1.Columns[18].Width = 100;
            dataGridView1.Columns[18].HeaderText = "配送方式";
            dataGridView1.Columns[19].Width = 100;
            dataGridView1.Columns[19].HeaderText = "退貨方式";
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                count++;
                isColorChanged = !isColorChanged;
                r.DefaultCellStyle.BackColor = Color.White;
                if (isColorChanged)
                    r.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
                r.Height = 30;
                r.HeaderCell.Value = count.ToString();
            }

            dataGridView2.Columns[0].Width = 0;
            dataGridView2.Columns[1].Width = 100;
            dataGridView2.Columns[1].HeaderText = "會員編號";
            dataGridView2.Columns[2].Width = 100;
            dataGridView2.Columns[2].HeaderText = "廠商編號";
            dataGridView2.Columns[3].Width = 100;
            dataGridView2.Columns[3].HeaderText = "捐款日期";
            dataGridView2.Columns[4].Width = 100;
            dataGridView2.Columns[4].HeaderText = "捐款金額";
            foreach (DataGridViewRow r2 in dataGridView2.Rows)
            {
                count++;
                isColorChanged = !isColorChanged;
                r2.DefaultCellStyle.BackColor = Color.White;
                if (isColorChanged)
                    r2.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                r2.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
                r2.Height = 30;
                r2.HeaderCell.Value = count.ToString();
            }

            dataGridView3.Columns[0].Width = 0;
            dataGridView3.Columns[1].Width = 100;
            dataGridView3.Columns[1].HeaderText = "會員編號";
            dataGridView3.Columns[2].Width = 100;
            dataGridView3.Columns[2].HeaderText = "訂單編號";
            dataGridView3.Columns[3].Width = 100;
            dataGridView3.Columns[3].HeaderText = "商品";
            dataGridView3.Columns[4].Width = 100;
            dataGridView3.Columns[4].HeaderText = "評價日期";
            dataGridView3.Columns[5].Width = 100;
            dataGridView3.Columns[5].HeaderText = "評價分數";
            dataGridView3.Columns[6].Width = 100;
            dataGridView3.Columns[6].HeaderText = "評價內容";
            foreach (DataGridViewRow r3 in dataGridView3.Rows)
            {
                count++;
                isColorChanged = !isColorChanged;
                r3.DefaultCellStyle.BackColor = Color.White;
                if (isColorChanged)
                    r3.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                r3.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
                r3.Height = 30;
                r3.HeaderCell.Value = count.ToString();
            }
        }

    }
}
