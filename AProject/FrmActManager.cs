using AProject.Component;
using AProject.Models;
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
    public partial class FrmActManager : Form
    {
        public static int userId = 11;
        private string SqlconnectS = @"Data Source=192.168.35.57,1433;Initial Catalog=Aproject;Persist Security Info=True;User ID=Lucy";
        //private string SqlconnectS = @"Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False";
        private int _position;
        private SqlDataAdapter _adapterAllAct;
        private SqlCommandBuilder _builderAllAct;
        private SqlDataAdapter _adapterInfo;
        private SqlCommandBuilder _builderInfo;
        private SqlDataAdapter _adapterDetail;
        private SqlCommandBuilder _builderDetail;
        private SqlDataAdapter _adapterImg;
        private SqlCommandBuilder _builderImg;
        private CAct _Act;
        private string sqlDisplay = "";
        public FrmActManager()
        {
            InitializeComponent();
        }

        private void btnCreatAct_Click(object sender, EventArgs e)
        {
            FrmActEditor f = new FrmActEditor();
            f.title = btnActCreate.Text + "活動";
            f.ShowDialog();
            if (f.isOk != DialogResult.OK)
                return;
            creatAct(f);

        }

        private void creatAct(FrmActEditor f)
        {
            CAct a = f.activity;

            string sqlActInfo = "Insert tActInformation (";
            sqlActInfo += "[fCompanyId],";
            sqlActInfo += "[fActName] ,";
            sqlActInfo += "[fActLocation],";
            sqlActInfo += "[fActDescription],";
            sqlActInfo += "[fActProcess],";
            sqlActInfo += "[fRegFee],";
            sqlActInfo += "[fMaxNumber],";
            sqlActInfo += "[fActUpdateDate],";
            sqlActInfo += "[fRemovalMark]";
            sqlActInfo += ") values (";
            sqlActInfo += "@KfCompanyId,";
            sqlActInfo += "@KfActName,";
            sqlActInfo += "@KfActLocation,";
            sqlActInfo += "@KfActDescription,";
            sqlActInfo += "@KfActProcess,";
            sqlActInfo += "@KfRegFee,";
            sqlActInfo += "@KfMaxNumber,";
            sqlActInfo += "@KfActUpdateDate,";
            sqlActInfo += "@KfRemovalMark";
            sqlActInfo += " ) ";

            SqlConnection con = new SqlConnection(SqlconnectS);
            con.Open();
            SqlTransaction transactionAct = con.BeginTransaction();

            try
            {
                SqlCommand cmdCreatAct = new SqlCommand(sqlActInfo, con);
                cmdCreatAct.Transaction = transactionAct;
                cmdCreatAct.Parameters.Add(new SqlParameter("KfCompanyId", (object)userId));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfActName", (object)a.fActName));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfActLocation", (object)a.fActLocation));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfActDescription", (object)a.fActDescription));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfActProcess", (object)a.fActSch));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfRegFee", (object)a.fActFee));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfMaxNumber", (object)a.fActNMax));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfActUpdateDate", (object)a.fEditorDay));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfRemovalMark", (object)a.fActStatus));
                cmdCreatAct.ExecuteNonQuery();


                SqlCommand sqlfindActId = new SqlCommand("select Max(fActId) as ActId from tActInformation", con);
                sqlfindActId.Transaction = transactionAct;
                SqlDataReader readFindAct = sqlfindActId.ExecuteReader();
                if (readFindAct.Read())
                {
                    string actId = readFindAct["ActId"].ToString();
                    readFindAct.Close();

                    if (a.fActImg != null)
                    {
                        string sqlActImg = "Insert tActImgData (";
                        sqlActImg += "[fActId],";
                        sqlActImg += "[fActImg],";
                        sqlActImg += "[fImgDescription]";
                        sqlActImg += ") values (";
                        sqlActImg += "@KfActId,";
                        sqlActImg += "@KfActImg,";
                        sqlActImg += "@KfImgDescription";
                        sqlActImg += " ) ";

                        SqlCommand cmdImg = new SqlCommand(sqlActImg, con);
                        cmdImg.Transaction = transactionAct;
                        cmdImg.Parameters.Add(new SqlParameter("KfActId", (object)actId));
                        cmdImg.Parameters.Add(new SqlParameter("@KfActImg", SqlDbType.Image) //指定欄位型態，不然會有錯誤訊息"運算元類型衝突: nvarchar 與 image 不相容"
                        { Value = (a.fActImg == null ? DBNull.Value : (object)a.fActImg) }); //用來初始化 SqlParameter 物件的 Value 屬性

                        cmdImg.Parameters.Add(new SqlParameter("KfImgDescription", (a.fActImgDescription) == null ? DBNull.Value : (object)a.fActImgDescription));
                        cmdImg.ExecuteNonQuery();
                    }                    

                    for (int i = 0; i < a.fActStartD.Count; i++)
                    {
                        string sqlActBatch = "Insert tActDetail (";
                        sqlActBatch += "[fActId],";
                        sqlActBatch += "[fStartDate],";
                        sqlActBatch += "[fEndDate],";
                        sqlActBatch += "[fRegStartDate],";
                        sqlActBatch += "[fRegDeadline]";
                        sqlActBatch += ") values (";
                        sqlActBatch += "@KfActId,";
                        sqlActBatch += "@KfStartDate,";
                        sqlActBatch += "@KfEndDate,";
                        sqlActBatch += "@KfRegStartDate,";
                        sqlActBatch += "@KfRegDeadline";
                        sqlActBatch += " ) ";

                        SqlCommand cmdBatch = new SqlCommand(sqlActBatch, con);
                        cmdBatch.Transaction = transactionAct;
                        cmdBatch.Parameters.Add(new SqlParameter("KfActId", (object)actId));
                        cmdBatch.Parameters.Add(new SqlParameter("KfStartDate", (object)a.fActStartD[i]));
                        cmdBatch.Parameters.Add(new SqlParameter("KfEndDate", (object)a.fActEndD[i]));
                        cmdBatch.Parameters.Add(new SqlParameter("KfRegStartDate", (object)a.fRegStartD[i]));
                        cmdBatch.Parameters.Add(new SqlParameter("KfRegDeadline", (object)a.fRegEndD[i]));
                        readFindAct.Close();
                        cmdBatch.ExecuteNonQuery();
                    }
                    transactionAct.Commit();
                }
                resetDisplay();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                transactionAct.Rollback();
                MessageBox.Show("活動新增失敗");
            }
        }

        private void FrmActManager_Load(object sender, EventArgs e)
        {
            resetDisplay();
        }

        private void resetDisplay()
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection con = new SqlConnection(SqlconnectS);
            con.Open();
            DataSet ds = new DataSet();

            _adapterInfo = new SqlDataAdapter("select * from tActInformation", con);
//keyword           // _adapterInfo.SelectCommand.Parameters.Add(new SqlParameter("Keyword"," Where ");
            _builderInfo = new SqlCommandBuilder(_adapterInfo);
            ds.Tables.Add("tActInformation");
            _adapterInfo.Fill(ds.Tables["tActInformation"]);

            _adapterDetail = new SqlDataAdapter("select * from tActDetail", con);
            _builderDetail = new SqlCommandBuilder(_adapterDetail);
            ds.Tables.Add("tActDetail");
            _adapterDetail.Fill(ds.Tables["tActDetail"]);

            _adapterImg = new SqlDataAdapter("select * from tActImgData", con);
            _builderImg = new SqlCommandBuilder(_adapterImg);
            ds.Tables.Add("tActImgData");
            _adapterImg.Fill(ds.Tables["tActImgData"]);

            con.Close();

            foreach (DataRow r in ds.Tables["tActInformation"].Rows)
            {
                CAct a = new CAct();
                a.fActId = Convert.ToInt32(r["fActId"]);
                a.fActName = r["fActName"].ToString();
                a.fActLocation = r["fActLocation"].ToString();
                a.fActNMax = Convert.ToInt32(r["fMaxNumber"]);
                a.fActFee = Math.Round(Convert.ToDecimal(r["fRegFee"]), 0);
                a.fUserId = Convert.ToInt32(r["fCompanyId"]);
                a.fActDescription = r["fActDescription"].ToString();
                a.fActSch = r["fActProcess"].ToString();
                a.fEditorDay = Convert.ToDateTime(r["fActUpdateDate"]);
                a.fActStatus = Convert.ToBoolean(r["fRemovalMark"]);
                a.fActClosed = r["fActClosed"].ToString();

                a.fActStartD = new List<string>();
                a.fActEndD = new List<string>();
                a.fRegStartD = new List<string>();
                a.fRegEndD = new List<string>();
                foreach (DataRow rInfo in ds.Tables["tActDetail"].Rows)
                {
                    if (Convert.ToInt32(rInfo["fActId"]) == a.fActId)
                    {
                        a.fActStartD.Add(rInfo["fStartDate"].ToString());
                        a.fActEndD.Add(rInfo["fEndDate"].ToString());
                        a.fRegStartD.Add(rInfo["fRegStartDate"].ToString());
                        a.fRegEndD.Add(rInfo["fRegDeadline"].ToString());
                    }
                }
                a.fActBatch = a.fActStartD.Count;
                foreach (DataRow rImg in ds.Tables["tActImgData"].Rows)
                {
                    if (Convert.ToInt32(rImg["fActId"]) == a.fActId)
                    {
                        if (rImg["fActImg"] != DBNull.Value)
                        {
                            a.fImgId = Convert.ToInt32(rImg["fImgId"]);
                            a.fActImg = (byte[])rImg["fActImg"];
                        }
                    }
                }
                ActBox box = new ActBox();
                box.act = a;
                box.boxClick += this.actClick;
                flowLayoutPanel1.Controls.Add(box);
            }
        }

        public void actClick(CAct a)
        {
            if (_Act == null )
            {
                _Act = new CAct();
            }
            _Act = a;
            ActKeyword.Text = a.fActName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_Act == null)
                return;
            FrmActEditor fe = new FrmActEditor();
            fe.title = toolStripButton3 + "活動";
            fe.activity = _Act;
            fe.ShowDialog();
            if (fe.isOk != DialogResult.OK)
                return;
            CAct a = fe.activity;

            string sqlActInfo = "Update tActInformation SET ";
            sqlActInfo += "[fCompanyId] = ";
            sqlActInfo += "@KfCompanyId,";
            sqlActInfo += "[fActName] = ";
            sqlActInfo += "@KfActName,";
            sqlActInfo += "[fActLocation] = ";
            sqlActInfo += "@KfActLocation,";
            sqlActInfo += "[fActDescription] = ";
            sqlActInfo += "@KfActDescription,";
            sqlActInfo += "[fActProcess] = ";
            sqlActInfo += "@KfActProcess,";
            sqlActInfo += "[fRegFee] = ";
            sqlActInfo += "@KfRegFee,";
            sqlActInfo += "[fMaxNumber] = ";
            sqlActInfo += "@KfMaxNumber,";
            sqlActInfo += "[fActUpdateDate] = ";
            sqlActInfo += "@KfActUpdateDate,";
            sqlActInfo += "[fRemovalMark] = ";
            sqlActInfo += "@KfRemovalMark,";
            if (a.fActClosed != null)
            {
                sqlActInfo += "[fActClosed] = ";
                sqlActInfo += "@KfActClosed";
            }
            sqlActInfo += " WHERE [fActId] = ";
            sqlActInfo += "@KfActId; ";

            SqlConnection con = new SqlConnection(SqlconnectS);
            con.Open();
            SqlTransaction transactionAct = con.BeginTransaction();

            try
            {
                SqlCommand cmdCreatAct = new SqlCommand(sqlActInfo, con);
                cmdCreatAct.Transaction = transactionAct;
                cmdCreatAct.Parameters.Add(new SqlParameter("KfCompanyId", (object)userId));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfActName", (object)a.fActName));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfActLocation", (object)a.fActLocation));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfActDescription", (object)a.fActDescription));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfActProcess", (object)a.fActSch));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfRegFee", (object)a.fActFee));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfMaxNumber", (object)a.fActNMax));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfActUpdateDate", (object)a.fEditorDay));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfRemovalMark", (object)a.fActStatus));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfActId", (object)a.fActId));
                cmdCreatAct.Parameters.Add(new SqlParameter("KfActClosed", (object)a.fActClosed));
                cmdCreatAct.ExecuteNonQuery();


                SqlCommand sqlfindImg = new SqlCommand("select * from tActImgData Where [fActId] = @KfActId", con);
                sqlfindImg.Parameters.Add(new SqlParameter("KfActId", (object)a.fActId));
                sqlfindImg.Transaction = transactionAct;
                SqlDataReader readFindImg = sqlfindImg.ExecuteReader();
                string sqlActImg = "";
                if (readFindImg.Read())
                {                    
                    sqlActImg = "UPdate tActImgData set ";
                    sqlActImg += "[fActImg] = ";
                    sqlActImg += "@KfActImg,";
                    sqlActImg += "[fImgDescription] = ";
                    sqlActImg += "@KfImgDescription";
                    sqlActImg += " WHERE [fActId] = ";
                    sqlActImg += "@KfActId; ";
                }
                else 
                {
                    sqlActImg = "Insert tActImgData (";
                    sqlActImg += "[fActId],";
                    sqlActImg += "[fActImg],";
                    sqlActImg += "[fImgDescription]";
                    sqlActImg += ") values (";
                    sqlActImg += "@KfActId,";
                    sqlActImg += "@KfActImg,";
                    sqlActImg += "@KfImgDescription";
                    sqlActImg += " ) ";
                }
                readFindImg.Close();
                SqlCommand cmdImg = new SqlCommand(sqlActImg, con);
                cmdImg.Transaction = transactionAct;
                cmdImg.Parameters.Add(new SqlParameter("KfActId", (object)a.fActId));
                cmdImg.Parameters.Add(new SqlParameter("@KfActImg", SqlDbType.Image) //指定欄位型態，不然會有錯誤訊息"運算元類型衝突: nvarchar 與 image 不相容"
                { Value = (a.fActImg == null ? DBNull.Value : (object)a.fActImg) }); //用來初始化 SqlParameter 物件的 Value 屬性

                cmdImg.Parameters.Add(new SqlParameter("KfImgDescription", (a.fActImgDescription) == null ? DBNull.Value : (object)a.fActImgDescription));
                cmdImg.ExecuteNonQuery();


                SqlCommand sqlfindDay = new SqlCommand("select * from tActDetail Where [fActId] = @KfActId", con);
                sqlfindDay.Parameters.Add(new SqlParameter("KfActId", (object)a.fActId));
                sqlfindDay.Transaction = transactionAct;
                SqlDataReader readFindDay = sqlfindDay.ExecuteReader();
                List<int> fActDetailId = new List<int>();
                while (readFindDay.Read())
                {
                    fActDetailId.Add(Convert.ToInt32(readFindDay["fActDetailId"])); //3
                }
                readFindDay.Close();
                string sqlActDay = "";
                int i = 0;
                for ( i = 0; i < fActDetailId.Count(); i++)
                {
                    if (i < a.fActStartD.Count())//修改
                    {
                        sqlActDay = "update tActDetail set ";
                        sqlActDay += "[fActId] = ";
                        sqlActDay += "@KfActId,";
                        sqlActDay += "[fStartDate] =";
                        sqlActDay += "@KfStartDate,";
                        sqlActDay += "[fEndDate] = ";
                        sqlActDay += "@KfEndDate,";
                        sqlActDay += "[fRegStartDate] = ";
                        sqlActDay += "@KfRegStartDate,";
                        sqlActDay += "[fRegDeadline] = ";
                        sqlActDay += "@KfRegDeadline";
                        sqlActDay += " WHERE [fActDetailId] = ";
                        sqlActDay += "@KfActDetailId; ";
                    }
                    else//刪除
                    {
                        sqlActDay = "delect from tActDetail";
                        sqlActDay += " WHERE [fActDetailId] = ";
                        sqlActDay += "@KfActDetailId; ";
                    }
                    SqlCommand cmdDay = new SqlCommand(sqlActDay, con);
                    cmdDay.Transaction = transactionAct;
                    cmdDay.Parameters.Add(new SqlParameter("KfActId", (object)a.fActId));
                    cmdDay.Parameters.Add(new SqlParameter("KfStartDate", (object)a.fActStartD[i]));
                    cmdDay.Parameters.Add(new SqlParameter("KfEndDate", (object)a.fActEndD[i]));
                    cmdDay.Parameters.Add(new SqlParameter("KfRegStartDate", (object)a.fRegStartD[i]));
                    cmdDay.Parameters.Add(new SqlParameter("KfRegDeadline", (object)a.fRegEndD[i]));
                    cmdDay.Parameters.Add(new SqlParameter("KfActDetailId", (object)fActDetailId[i]));                    
                    cmdDay.ExecuteNonQuery();
                }
                while (i < a.fActStartD.Count())//新增
                {
                    sqlActDay = "Insert tActDetail (";
                    sqlActDay += "[fActId],";
                    sqlActDay += "[fStartDate],";
                    sqlActDay += "[fEndDate],";
                    sqlActDay += "[fRegStartDate],";
                    sqlActDay += "[fRegDeadline]";
                    sqlActDay += ") values (";
                    sqlActDay += "@KfActId,";
                    sqlActDay += "@KfStartDate,";
                    sqlActDay += "@KfEndDate,";
                    sqlActDay += "@KfRegStartDate,";
                    sqlActDay += "@KfRegDeadline";
                    sqlActDay += " ) ";

                    SqlCommand cmdDay = new SqlCommand(sqlActDay, con);
                    cmdDay.Transaction = transactionAct;
                    cmdDay.Parameters.Add(new SqlParameter("KfActId", (object)a.fActId));
                    cmdDay.Parameters.Add(new SqlParameter("KfStartDate", (object)a.fActStartD[i]));
                    cmdDay.Parameters.Add(new SqlParameter("KfEndDate", (object)a.fActEndD[i]));
                    cmdDay.Parameters.Add(new SqlParameter("KfRegStartDate", (object)a.fRegStartD[i]));
                    cmdDay.Parameters.Add(new SqlParameter("KfRegDeadline", (object)a.fRegEndD[i]));                    
                    cmdDay.ExecuteNonQuery();
                    i++;
                }
                transactionAct.Commit();
                con.Close();
                resetDisplay();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                transactionAct.Rollback();
                MessageBox.Show("活動新增失敗");
                resetDisplay();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            resetDisplay();
        }

        private void copyAct_Click(object sender, EventArgs e)
        {
            if (_Act == null)
                return;
            FrmActEditor fe = new FrmActEditor();
            fe.title = toolStripButton1.Text + "活動";
            fe.activity = _Act;
            fe.ShowDialog();
            if (fe.isOk != DialogResult.OK)
                return;
            creatAct(fe);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_Act == null)
                return;
            try
            {
                SqlConnection con = new SqlConnection(SqlconnectS);
                con.Open();
                SqlTransaction sqlTransaction = con.BeginTransaction();
                string sqlDelete = "delete tActImgData where [fActId] = @KfActId";
                SqlCommand cmdDelete = new SqlCommand(sqlDelete, con, sqlTransaction);
                cmdDelete.Parameters.Add(new SqlParameter("KfActId", (object)_Act.fActId));
                cmdDelete.ExecuteNonQuery();

                sqlDelete = "delete tActDetail where [fActId] = @KfActId";
                cmdDelete = new SqlCommand(sqlDelete, con, sqlTransaction);
                cmdDelete.Parameters.Add(new SqlParameter("KfActId", (object)_Act.fActId));
                cmdDelete.ExecuteNonQuery();

                sqlDelete = "delete tActInformation where [fActId] = @KfActId";
                cmdDelete = new SqlCommand(sqlDelete, con, sqlTransaction);
                cmdDelete.Parameters.Add(new SqlParameter("KfActId", (object)_Act.fActId));
                cmdDelete.ExecuteNonQuery();

                sqlTransaction.Commit();
                con.Close();
                resetDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("刪除失敗，請確認活動是否使用中");
                return;
            }            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
