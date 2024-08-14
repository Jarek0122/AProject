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

        //private string SqlconnectS = @"Data Source=192.168.35.57,1433;Initial Catalog=Aproject;Persist Security Info=True;User ID=Lucy";
        private string SqlconnectS = @"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False";
        SqlDataAdapter _adapterAct;
        SqlCommandBuilder _builderAct;
        SqlDataAdapter _adapterRecord;
        SqlCommandBuilder _builderRecord;
        private void FrmActRecord_Load(object sender, EventArgs e)
        {
            string sqlAct = "Select * from tActInformation a left join tActDetail b on a.fActId = b.fActId";
            string sqlRecord = "Select * from tActDetail a left join tEventReg b on a.fActDetailID = b.fActDetailID";
            SqlConnection con = new SqlConnection(SqlconnectS);
            con.Open();
            _adapterAct = new SqlDataAdapter(sqlAct,con);
            _adapterRecord = new SqlDataAdapter(sqlRecord, con);
            _builderAct = new SqlCommandBuilder(_adapterAct);
            _builderRecord = new SqlCommandBuilder(_adapterRecord);
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("活動總表");
            DataTable dtr = ds.Tables.Add("報名清單");
            _adapterAct.Fill(dt);
            _adapterRecord.Fill(dtr);
            con.Close();

            ds.Tables["活動總表"].Columns.Add("報名人數");
            ds.Tables["活動總表"].Columns.Add("公開狀態");
            
            foreach (DataRow dr in dt.Rows)
            {
                int Regcount = 0;
                foreach (DataRow row in dtr.Rows)
                {                    
                    if (dr["fActDetailID"] == row["fActDetailID"]) { Regcount++; }
                }
                dr["報名人數"]= Regcount.ToString() + " / " + dr["fMaxNumber"].ToString();
                dr["fActUpdateDate"] = Convert.ToDateTime(dr["fActUpdateDate"]).ToString("yyyy/MM/dd");
                dr["fActClosed"] = dr["fActClosed"] == DBNull.Value?"": Convert.ToDateTime(dr["fActClosed"]).ToString("yyyy/MM/dd");
                dr["公開狀態"] = (bool)dr["fRemovalMark"] ? "公開" : "下架";
                dr["fRegFee"] = Convert.ToInt32(dr["fRegFee"]).ToString();                
            }
            dataGridView1.DataSource = dt;
            dt.Columns["fActUpdateDate"].SetOrdinal(dt.Columns.Count - 1);
            dt.Columns["fActClosed"].SetOrdinal(dt.Columns.Count - 1);

            dt.Columns["fCompanyId"].ColumnName = "廠商編號";
            dt.Columns["fActName"].ColumnName = "活動名稱";
            dt.Columns["fActLocation"].ColumnName = "地點";
            dt.Columns["fActUpdateDate"].ColumnName ="更新日期";
            dt.Columns["fActClosed"].ColumnName = "結案日期";
            dt.Columns["fRegFee"].ColumnName = "報名費用";
            dt.Columns["fStartDate"].ColumnName = "開放報名";
            dt.Columns["fEndDate"].ColumnName = "截止報名";
            dt.Columns["fRegStartDate"].ColumnName = "開始日期";
            dt.Columns["fRegDeadline"].ColumnName = "結束日期";
            dataGridView1.Columns["fActId"].Visible = false;
            dataGridView1.Columns["fImgId"].Visible = false;
            dataGridView1.Columns["fMaxNumber"].Visible = false;
            dataGridView1.Columns["fRemovalMark"].Visible = false;
            dataGridView1.Columns["fActDescription"].Visible = false;
            dataGridView1.Columns["fActProcess"].Visible = false;
            dataGridView1.Columns["fActDetailId"].Visible = false;
            dataGridView1.Columns["fActId1"].Visible = false;
            dataGridView1.Columns["fRemainingPlaces"].Visible = false;
            
        }
    }
}
