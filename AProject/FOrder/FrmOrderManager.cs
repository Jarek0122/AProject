using AProject.Model;
using AProject.Models;
using System;
using System.Collections;
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
                                o.fShippingInfo,
                                o.fInvoiceInfo,
                                o.fRecepientName,
                                o.fRecepientAddress,
                                o.fRecepientPhone,
                                o.fRecepientEmail,
                                o.fOrderRemarks,
                                o.fReturnInfo
                            FROM tOrder o
                            JOIN tOrderDetail od ON o.fOrderId = od.fOrderId", dataGridView1);

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

            if (dataGridView == dataGridView1)
            {
                _adapter.SelectCommand.Parameters.Add(
                new SqlParameter("K_KEYWORD", "%" + (object)txtOrder.Text + "%"));
            }
            else if (dataGridView == dataGridView2)
            {
                _adapter.SelectCommand.Parameters.Add(
                new SqlParameter("K_KEYWORD", "%" + (object)txtDonate.Text + "%"));
            }
            else if (dataGridView == dataGridView3)
            {
                _adapter.SelectCommand.Parameters.Add(
                new SqlParameter("K_KEYWORD", "%" + (object)txtReview.Text + "%"));
            }

            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            con.Close();
            dataGridView.DataSource = ds.Tables[0];
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
                                o.fShippingInfo,
                                o.fInvoiceInfo,
                                o.fRecepientName,
                                o.fRecepientAddress,
                                o.fRecepientPhone,
                                o.fRecepientEmail,
                                o.fOrderRemarks,
                                o.fReturnInfo
                            FROM tOrder o
                            JOIN tOrderDetail od ON o.fOrderId = od.fOrderId", dataGridView1);
        }


        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            if (_position >= 0)
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[_position];
                int orderId = Convert.ToInt32(selectedRow.Cells["fOrderId"].Value);

                using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tOrder WHERE fOrderId = @fOrderId", con);
                    cmd.Parameters.AddWithValue("@fOrderId", orderId);
                    cmd.ExecuteNonQuery();
                }

                btnOrderRefresh_Click(sender, e);
            }
        }

        private void btnOrderUpdate_Click(object sender, EventArgs e)
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
            //o.fShippingInfo = (string)dr["fShippinginfo"];
            //o.fInvoiceInfo = (string)dr["fInvoiceInfo"];
            //o.fRecepientName = (string)dr["fRecepientName"];
            //o.fRecepientAddress = (string)dr["fRecepientAddress"];
            //o.fRecepientPhone = (string)dr["fRecepientPhone"];
            //o.fRecepientEmail = (string)dr["fRecepientEmail"];
            //o.fOrderRemarks = (string)dr["fOrderRemarks"];
            //o.fReturnInfo = (string)dr["fReturnInfo"];

            //COrderDetail od = new COrderDetail();
            //if (dr["fProductId"] != DBNull.Value)
            //    od.fProductId = (int)dr["fProductId"];
            //od.fQuantity = (int)dr["fQuantity"];
            //od.fPrice = (decimal)dr["fPrice"];
            if (_position >= 0)
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[_position];
                int orderId = Convert.ToInt32(selectedRow.Cells["fOrderId"].Value);

                FrmOrderEditor f = new FrmOrderEditor();
                f.order = new COrder
                {
                    fUserId = Convert.ToInt32(selectedRow.Cells["fUserId"].Value),
                    fOrderDate = selectedRow.Cells["fOrderDate"].Value.ToString(),
                    fOrderStatus = selectedRow.Cells["fOrderStatus"].Value.ToString(),
                    fPromotionId = Convert.ToInt32(selectedRow.Cells["fPromotionId"].Value),
                    fPaymentStatus = Convert.ToBoolean(selectedRow.Cells["fPaymentStatus"].Value),
                    fShippingStatus = Convert.ToBoolean(selectedRow.Cells["fShippingStatus"].Value),
                    fServiceStatus = Convert.ToBoolean(selectedRow.Cells["fServiceStatus"].Value),
                    fPaymentInfo = selectedRow.Cells["fPaymentInfo"].Value.ToString(),
                    fShippingInfo = selectedRow.Cells["fShippingInfo"].Value.ToString(),
                    fInvoiceInfo = selectedRow.Cells["fInvoiceInfo"].Value.ToString(),
                    fRecepientName = selectedRow.Cells["fRecepientName"].Value.ToString(),
                    fRecepientAddress = selectedRow.Cells["fRecepientAddress"].Value.ToString(),
                    fRecepientPhone = selectedRow.Cells["fRecepientPhone"].Value.ToString(),
                    fRecepientEmail = selectedRow.Cells["fRecepientEmail"].Value.ToString(),
                    fOrderRemarks = selectedRow.Cells["fOrderRemarks"].Value.ToString(),
                    fReturnInfo = selectedRow.Cells["fReturnInfo"].Value.ToString()
                };

                f.ShowDialog();

                if (f.isOk == DialogResult.OK)
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"UPDATE tOrder SET 
                                                    fUserId = @fUserId,
                                                    fOrderDate = @fOrderDate, 
                                                    fOrderStatus = @fOrderStatus, 
                                                    fPromotionId = @fPromotionId, 
                                                    fPaymentStatus = @fPaymentStatus, 
                                                    fShippingStatus = @fShippingStatus, 
                                                    fServiceStatus = @fServiceStatus, 
                                                    fPaymentInfo = @fPaymentInfo, 
                                                    fShippingInfo = @fShippingInfo, 
                                                    fInvoiceInfo = @fInvoiceInfo, 
                                                    fRecepientName = @fRecepientName, 
                                                    fRecepientAddress = @fRecepientAddress, 
                                                    fRecepientPhone = @fRecepientPhone, 
                                                    fRecepientEmail = @fRecepientEmail, 
                                                    fOrderRemarks = @fOrderRemarks, 
                                                    fReturnInfo = @fReturnInfo
                                                  WHERE fOrderId = @fOrderId", con);

                        cmd.Parameters.AddWithValue("@fUserId", f.order.fUserId);
                        cmd.Parameters.AddWithValue("@fOrderDate", f.order.fOrderDate);
                        cmd.Parameters.AddWithValue("@fOrderStatus", f.order.fOrderStatus);
                        cmd.Parameters.AddWithValue("@fPromotionId", f.order.fPromotionId);
                        cmd.Parameters.AddWithValue("@fPaymentStatus", f.order.fPaymentStatus);
                        cmd.Parameters.AddWithValue("@fShippingStatus", f.order.fShippingStatus);
                        cmd.Parameters.AddWithValue("@fServiceStatus", f.order.fServiceStatus);
                        cmd.Parameters.AddWithValue("@fPaymentInfo", f.order.fPaymentInfo);
                        cmd.Parameters.AddWithValue("@fShippingInfo", f.order.fShippingInfo);
                        cmd.Parameters.AddWithValue("@fInvoiceInfo", f.order.fInvoiceInfo);
                        cmd.Parameters.AddWithValue("@fRecepientName", f.order.fRecepientName);
                        cmd.Parameters.AddWithValue("@fRecepientAddress", f.order.fRecepientAddress);
                        cmd.Parameters.AddWithValue("@fRecepientPhone", f.order.fRecepientPhone);
                        cmd.Parameters.AddWithValue("@fRecepientEmail", f.order.fRecepientEmail);
                        cmd.Parameters.AddWithValue("@fOrderRemarks", f.order.fOrderRemarks);
                        cmd.Parameters.AddWithValue("@fReturnInfo", f.order.fReturnInfo);
                        cmd.Parameters.AddWithValue("@fOrderId", orderId);
                        cmd.ExecuteNonQuery();
                    }

                    btnOrderRefresh_Click(sender, e);
                }
            }
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
            //    o.fShippingInfo,
            //    o.fInvoiceInfo,
            //    o.fRecepientName,
            //    o.fRecepientAddress,
            //    o.fRecepientPhone,
            //    o.fRecepientEmail,
            //    o.fOrderRemarks,
            //    o.fReturnInfo
            //FROM tOrder o
            //JOIN tOrderDetail od ON o.fOrderId = od.fOrderId",dataGridView1);
            //sql += " WHERE o.fRecepientEmail LIKE @K_KEYWORD";

            //displayBySql(sql,dataGridView1);
        }

        private void btnDonateRefresh_Click(object sender, EventArgs e)
        {
            displayBySql(@" SELECT * FROM tDonation", dataGridView2);
        }

        private void btnDonateCreate_Click(object sender, EventArgs e)
        {
            FrmDonationEditor f = new FrmDonationEditor();
            f.title = "新增捐款紀錄";
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
                //DataTable dt = dataGridView2.DataSource as DataTable;
                //DataRow dr = dt.NewRow();
                //dr["fUserId"] = f.donation.fUserId;
                //dr["fCompanyId"] = f.donation.fCompanyId;
                //dr["fDonationDate"] = f.donation.fDonationDate;
                //dr["fAmount"] = f.donation.fAmount;
                //dt.Rows.Add(dr);
                using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tDonation (fUserId, fCompanyId, fDonationDate, fAmount) VALUES (@fUserId, @fCompanyId, @fDonationDate, @fAmount)", con);
                    cmd.Parameters.AddWithValue("@fUserId", f.donation.fUserId);
                    cmd.Parameters.AddWithValue("@fCompanyId", f.donation.fCompanyId);
                    cmd.Parameters.AddWithValue("@fDonationDate", f.donation.fDonationDate);
                    cmd.Parameters.AddWithValue("@fAmount", f.donation.fAmount);
                    cmd.ExecuteNonQuery();
                }

                btnDonateRefresh_Click(sender, e);
            }
        }

        private void btnDonateDelete_Click(object sender, EventArgs e)
        {
            //DataTable dt = dataGridView2.DataSource as DataTable;
            //DataRow dr = dt.Rows[_position];
            //dr.Delete();
            //_adapter.Update(dataGridView2.DataSource as DataTable);

            if (_position >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[_position];
                int donationId = Convert.ToInt32(selectedRow.Cells["fDonationId"].Value);

                using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tDonation WHERE fDonationId = @fDonationId", con);
                    cmd.Parameters.AddWithValue("@fDonationId", donationId);
                    cmd.ExecuteNonQuery();
                }

                btnDonateRefresh_Click(sender, e);
            }
        }

        private void btnDonateUpdate_Click(object sender, EventArgs e)
        {
            //DataTable dt = dataGridView2.DataSource as DataTable;
            //DataRow dr = dt.Rows[_position];
            //CDonation d = new CDonation();
            //d.fAmount = (decimal)dr["fAmount"];
            //if (dr["fUserId"] != DBNull.Value)
            //    d.fUserId = (int)dr["fUserId"];
            //if (dr["fCompanyId"] != DBNull.Value)
            //    d.fCompanyId = (int)dr["fCompanyId"];
            //d.fDonationDate = dr["fDonationDate"].ToString();

            //FrmDonationEditor f = new FrmDonationEditor();
            //f.title = "編輯捐款紀錄";
            //f.donation = d;
            //f.ShowDialog();
            //if (f.isOk == DialogResult.OK)
            //{
            //    dr["fUserId"] = f.donation.fUserId;
            //    dr["fCompanyId"] = f.donation.fCompanyId;
            //    dr["fDonationDate"] = f.donation.fDonationDate;
            //    dr["fAmount"] = f.donation.fAmount;
            //}

            if (_position >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[_position];
                int donationId = Convert.ToInt32(selectedRow.Cells["fDonationId"].Value);

                FrmDonationEditor f = new FrmDonationEditor();
                f.donation = new CDonation
                {
                    fUserId = Convert.ToInt32(selectedRow.Cells["fUserId"].Value),
                    fCompanyId = Convert.ToInt32(selectedRow.Cells["fCompanyId"].Value),
                    fDonationDate = selectedRow.Cells["fDonationDate"].Value.ToString(),
                    fAmount = Convert.ToDecimal(selectedRow.Cells["fAmount"].Value)
                };

                f.title = "編輯捐款紀錄";
                f.ShowDialog();

                if (f.isOk == DialogResult.OK)
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"UPDATE tDonation SET 
                                                    fUserId = @fUserId,
                                                    fCompanyId = @fCompanyId, 
                                                    fDonationDate = @fDonationDate, 
                                                    fAmount = @fAmount 
                                                  WHERE fDonationId = @fDonationId", con);
                        cmd.Parameters.AddWithValue("@fUserId", f.donation.fUserId);
                        cmd.Parameters.AddWithValue("@fCompanyId", f.donation.fCompanyId);
                        cmd.Parameters.AddWithValue("@fDonationDate", f.donation.fDonationDate);
                        cmd.Parameters.AddWithValue("@fAmount", f.donation.fAmount);
                        cmd.Parameters.AddWithValue("@fDonationId", donationId);
                        cmd.ExecuteNonQuery();
                    }

                    btnDonateRefresh_Click(sender, e);
                }
            }
        }

        private void btnDonateRead_Click(object sender, EventArgs e)
        {
            //string sql = "SELECT * FROM tDonation";
            //sql += " WHERE fCompanyId LIKE @K_KEYWORD";

            //displayBySql(sql, dataGridView2);
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
                            FROM tOrderDetail od
                            JOIN tOrder o ON od.fOrderId = o.fOrderId", dataGridView3);
        }
        
        private void btnReviewCreate_Click(object sender, EventArgs e)
        {
            FrmReviewEditor f = new FrmReviewEditor();
            f.title = "新增評價";
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tOrderDetail (fOrderId, fProductId, fReviewDate, fReviewScore, fProductReview) VALUES (@fOrderId, @fProductId, @fReviewDate, @fReviewScore, @fProductReview)", con);
                    cmd.Parameters.AddWithValue("@fOrderId", f.order.fOrderId);
                    cmd.Parameters.AddWithValue("@fProductId", f.orderdetail.fProductId);
                    cmd.Parameters.AddWithValue("@fReviewDate", f.orderdetail.fReviewDate);
                    cmd.Parameters.AddWithValue("@fReviewScore", f.orderdetail.fReviewScore);
                    cmd.Parameters.AddWithValue("@fProductReview", f.orderdetail.fProductReview);
                    cmd.ExecuteNonQuery();
                }

                btnReviewRefresh_Click(sender, e);
            }
        }

        private void btnReviewDelete_Click(object sender, EventArgs e)
        {
            if (_position >= 0)
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[_position];
                int orderdetailId = Convert.ToInt32(selectedRow.Cells["fOrderDetailId"].Value);

                using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tOrderDetail WHERE fOrderDetailId = @fOrderDetailId", con);
                    cmd.Parameters.AddWithValue("@fOrderDetailId", orderdetailId);
                    cmd.ExecuteNonQuery();
                }

                btnReviewRefresh_Click(sender, e);
            }
        }

        private void btnReviewUpdate_Click(object sender, EventArgs e)
        {
            if (_position >= 0)
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[_position];
                int orderdetailId = Convert.ToInt32(selectedRow.Cells["fOrderDetailId"].Value);

                FrmReviewEditor f = new FrmReviewEditor();
                f.orderdetail = new COrderDetail
                {
                    fOrderId = Convert.ToInt32(selectedRow.Cells["fOrderId"].Value),
                    fProductId = Convert.ToInt32(selectedRow.Cells["fProductId"].Value),
                    fReviewDate = selectedRow.Cells["fReviewDate"].Value.ToString(),
                    fReviewScore = Convert.ToInt32(selectedRow.Cells["fReviewScore"].Value),
                    fProductReview = selectedRow.Cells["fProductReview"].Value.ToString()
                };

                f.title = "編輯評價";
                f.ShowDialog();

                if (f.isOk == DialogResult.OK)
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"UPDATE tOrderDetail SET 
                                                    fOrderId = @fOrderId,
                                                    fProductId = @fProductId, 
                                                    fReviewDate = @fReviewDate, 
                                                    fReviewScore = @fReviewScore,
                                                    fProductReview = @fProductReview
                                                  WHERE fOrderDetailId = @fOrderDetailId", con);
                        cmd.Parameters.AddWithValue("@fOrderId", f.order.fOrderId);
                        cmd.Parameters.AddWithValue("@fProductId", f.orderdetail.fProductId);
                        cmd.Parameters.AddWithValue("@fReviewDate", f.orderdetail.fReviewDate);
                        cmd.Parameters.AddWithValue("@fReviewScore", f.orderdetail.fReviewScore);
                        cmd.Parameters.AddWithValue("@fProductReview", f.orderdetail.fProductReview);
                        cmd.Parameters.AddWithValue("@fOrderDetailId", orderdetailId);
                        cmd.ExecuteNonQuery();
                    }
                    btnReviewRefresh_Click(sender, e);
                }
            }
        }

        private void btnReviewRead_Click(object sender, EventArgs e)
        {
            //???
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
            dataGridView1.Columns[10].HeaderText = "服務狀態";
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
                r.Height = 20;
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
                r2.Height = 20;
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
                r3.Height = 20;
                r3.HeaderCell.Value = count.ToString();
            }
        }

    }
}
