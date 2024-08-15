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

namespace AProject.View
{
    public partial class FrmActRecord : Form
    {
        public FrmActRecord()
        {
            InitializeComponent();
        }

        private string SqlconnectS = @"Data Source=192.168.35.57,1433;Initial Catalog=Aproject;Persist Security Info=True;User ID=Lucy";
        //private string SqlconnectS = @"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False";
        private SqlDataAdapter _adapterAct;
        private SqlCommandBuilder _builderAct;
        private SqlDataAdapter _adapterRecord;
        private SqlCommandBuilder _builderRecord;
        private string _clickAct ;
        private string _ActData ;
        private DataSet ds;
        private void FrmActRecord_Load(object sender, EventArgs e)
        {
            resetDisplay();

        }

        private void resetDisplay()
        {
            SqlConnection con = new SqlConnection(SqlconnectS);
            con.Open();
            string sqlAct = "Select * from tActInformation a left join tActDetail b on a.fActId = b.fActId";
            _adapterAct = new SqlDataAdapter(sqlAct, con);
            _builderAct = new SqlCommandBuilder(_adapterAct);
            ds = new DataSet();
            DataTable dt = ds.Tables.Add("活動總表");
            _adapterAct.Fill(dt);

            string sqlRecord = "Select * from tRegDetails a left join tEventReg b on a.fRegID = b.fRegID";
            _adapterRecord = new SqlDataAdapter(sqlRecord, con);
            _builderRecord = new SqlCommandBuilder(_adapterRecord);
            DataTable dtr = ds.Tables.Add("報名清單");
            _adapterRecord.Fill(dtr);
            
            con.Close();

            ds.Tables.Add("單一活動查詢結果");
            ds.Tables["活動總表"].Columns.Add("報名人數");
            ds.Tables["活動總表"].Columns.Add("公開狀態");

            foreach (DataRow dr in dt.Rows)
            {
                int Regcount = 0;
                foreach (DataRow row in dtr.Rows)
                {
                    if (dr["fActDetailID"].Equals(row["fActDetailID"]) && (bool)row["fPaymentStatus"] == true) { Regcount++; }
                }
                dr["報名人數"] = Regcount.ToString() + " / " + dr["fMaxNumber"].ToString();
                dr["fActUpdateDate"] = Convert.ToDateTime(dr["fActUpdateDate"]).ToString("yyyy/MM/dd");

                dr["fActClosed"] = (dr["fActClosed"] == DBNull.Value) ? "" : Convert.ToDateTime(dr["fActClosed"]).ToString("yyyy/MM/dd");
                dr["公開狀態"] = (bool)dr["fRemovalMark"] ? "公開" : "下架";
                dr["fRegFee"] = Convert.ToInt32(dr["fRegFee"]).ToString();
            }
            dt.Columns["fActUpdateDate"].SetOrdinal(dt.Columns.Count - 1);
            dt.Columns["fActClosed"].SetOrdinal(dt.Columns.Count - 1);

            dt.Columns["fCompanyId"].ColumnName = "廠商編號";
            dt.Columns["fActName"].ColumnName = "活動名稱";
            dt.Columns["fActLocation"].ColumnName = "地點";
            dt.Columns["fActUpdateDate"].ColumnName = "更新日期";
            dt.Columns["fActClosed"].ColumnName = "結案日期";
            dt.Columns["fRegFee"].ColumnName = "報名費用";
            dt.Columns["fStartDate"].ColumnName = "開放報名";
            dt.Columns["fEndDate"].ColumnName = "截止報名";
            dt.Columns["fRegStartDate"].ColumnName = "開始日期";
            dt.Columns["fRegDeadline"].ColumnName = "結束日期";//以上是整理DataTable dt

            dataGridView1.DataSource = dt;
            int countAct = 0;
            foreach (DataGridViewRow c in dataGridView1.Rows)
            {
                countAct++;
                c.HeaderCell.Value = countAct.ToString();
            }
            dataGridView1.Columns["fActId"].Visible = false;
            dataGridView1.Columns["fImgId"].Visible = false;
            dataGridView1.Columns["fMaxNumber"].Visible = false;
            dataGridView1.Columns["fRemovalMark"].Visible = false;
            dataGridView1.Columns["fActDescription"].Visible = false;
            dataGridView1.Columns["fActProcess"].Visible = false;
            dataGridView1.Columns["fActDetailId"].Visible = false;
            dataGridView1.Columns["fActId1"].Visible = false;
            dataGridView1.Columns["fRemainingPlaces"].Visible = false;
            dataGridView1.Columns["廠商編號"].Width = 80;
            dataGridView1.Columns["活動名稱"].Width = 80;
            dataGridView1.Columns["地點"].Width = 80;
            dataGridView1.Columns["報名費用"].Width = 80;
            dataGridView1.Columns["開放報名"].Width = 80;
            dataGridView1.Columns["截止報名"].Width = 80;
            dataGridView1.Columns["開始日期"].Width = 80;
            dataGridView1.Columns["結束日期"].Width = 80;
            dataGridView1.Columns["報名人數"].Width = 80;
            dataGridView1.Columns["公開狀態"].Width = 80;
            dataGridView1.Columns["更新日期"].Width = 80;
            dataGridView1.Columns["結案日期"].Width = 80;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.RowHeadersWidth = 8;

            dataGridView2.DataSource = ds.Tables["報名清單"];
            ds.Tables["報名清單"].Columns["fUserId"].ColumnName = "填表會員編號";
            ds.Tables["報名清單"].Columns["填表會員編號"].SetOrdinal(0);
            ds.Tables["報名清單"].Columns["fRegName"].ColumnName = "參加者姓名";
            ds.Tables["報名清單"].Columns["fRegTel"].ColumnName = "電話";
            ds.Tables["報名清單"].Columns["fRegEmail"].ColumnName = "信箱";
            ds.Tables["報名清單"].Columns["fRecipientAddress"].ColumnName = "地址";
            ds.Tables["報名清單"].Columns["fRegStatus"].ColumnName = "報名狀態";
            //ds.Tables["報名清單"].Columns["fPaymentStatus"].ColumnName = "付款狀態";
            ds.Tables["報名清單"].Columns["fRegDate"].ColumnName = "報名日期";
            dataGridView2.Columns["fRegDetailsId"].Visible = false;
            dataGridView2.Columns["fRegID"].Visible = false;
            dataGridView2.Columns["fRegID1"].Visible = false;
            dataGridView2.Columns["fActDetailID"].Visible = false;
            dataGridView2.Columns["fActPayment"].Visible = false;
            dataGridView2.Columns["fPaymentInfo"].Visible = false;

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //string sortClick = dataGridView1.Columns[e.ColumnIndex].Name ;
            //sortClick += dataGridView1.SortOrder.ToString().Equals("Ascending")? " ASCE": " DESC";
            ////MessageBox.Show(sortClick);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.Rows[e.RowIndex];
            _clickAct = (dr.Cells["活動名稱"].Value.ToString());
            MessageBox.Show(_clickAct);

            
            DataTable dt = ds.Tables["報名清單"].Clone();
            foreach (DataRow drf in ds.Tables["報名清單"].Rows)
            {
                if ((drf["fActDetailId"]).ToString().Equals(dr.Cells["fActDetailId"].Value.ToString()))
                   dt.ImportRow(drf);
            }
            dataGridView2.DataSource = dt;

            _ActData = "    開始日期 : " + dr.Cells["開始日期"].Value.ToString();
            _ActData += "    結束日期 : " + dr.Cells["結束日期"].Value.ToString();
            _ActData += "    報名人數 : " + dr.Cells["報名人數"].Value.ToString();
        }

        private void dataGridView2_DataSourceChanged(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "目前顯示 " + (string.IsNullOrEmpty(_clickAct) ? "全部" : _clickAct) + " 報名人員資料" + _ActData;
            _clickAct = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            resetDisplay();
        }
    }
}
