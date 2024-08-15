using AProject.Component;
using AProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AProject.View
{
    public partial class FrmActEditor : Form
    {
        public FrmActEditor()
        {
            InitializeComponent();
        }
        private CAct _activity = null;
        private bool _ActStatus { get; set; }
        private List<string> _ActStartD;
        private List<string> _ActEndD;
        private List<string> _RegStartD;
        private List<string> _RegEndD;
        private DialogResult _isOk;
        public DialogResult isOk { get { return _isOk; } }

        public CAct activity
        {
            get
            {
                if (_activity == null)
                    _activity = new CAct();
                _activity.fUserId = FrmActManager.userId; //Form1.userId;
                _activity.fEditorDay = DateTime.Now.Date; //Form1.userId;
                _activity.fActName = txtActName.fTxtBoxValue;
                _activity.fActLocation = txtActlocation.fTxtBoxValue;
                _activity.fActFee = Convert.ToDecimal(txtActFee.fTxtBoxValue);
                _activity.fActNMax = Convert.ToInt32(txtActNMax.fTxtBoxValue);
                _activity.fActBatch = Convert.ToInt32(BatchValue.Value);                
                _activity.fActStartD = _ActStartD;
                _activity.fActEndD = _ActEndD;
                _activity.fRegStartD = _RegStartD;
                _activity.fRegEndD = _RegEndD;
                _activity.fActSch = txtActSch.Text;
                _activity.fActDescription = txtActDescription.Text;
                _activity.fActStatus = btnStatusT.Checked;
                return _activity;
                
            }
            set
            {
                _activity = value;
                _activity.fUserId = FrmActManager.userId; //Form1.userId;
                _activity.fEditorDay = DateTime.Now; //Form1.userId;
                txtActName.fTxtBoxValue =  _activity.fActName;
                txtActlocation.fTxtBoxValue = _activity.fActLocation;
                txtActFee.fTxtBoxValue = _activity.fActFee.ToString();
                txtActNMax.fTxtBoxValue = _activity.fActNMax.ToString();
                BatchValue.Value = _activity.fActBatch;
                _ActStartD = _activity.fActStartD;
                _ActEndD = _activity.fActEndD;
                _RegStartD = _activity.fRegStartD;
                _RegEndD = _activity.fRegEndD;
                txtActSch.Text = _activity.fActSch;
                txtActDescription.Text = _activity.fActDescription;
                btnStatusT.Checked =_activity.fActStatus;
                if (_activity.fActImg != null)
                {
                    Stream streamImg = new MemoryStream(_activity.fActImg);
                    pictureBox1.Image = Bitmap.FromStream(streamImg);
                }

                ActBatchDate();
            }
        }

        public string title
        {
            get { return this.Text; }
            set { this.Text = value; }
        }


        private void FrmActEditor_Load(object sender, EventArgs e)
        {
            this.Text = "   " + title;
            BatchValue.Minimum = 1;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            txtActEditorD.fTxtBoxValue = DateTime.Now.ToString("yyyy/MM/dd");

            txtActName.fEnable = true;
            if (this.Text.Trim().Equals("修改活動"))
                txtActName.fEnable = false;
            recordDate();
            ActBatchDate();
        }

        /// <summary>
        /// 依據輸入的批次數值更新表格尺寸
        /// </summary>
        private void ActBatchDate()
        {
            dataGridView1.DataSource = null;
            DataTable dsBatch = new DataTable();
            DataColumn[] dcBatch = new DataColumn[5]
            {
                new DataColumn("批次"),
                new DataColumn("開放報名"),
                new DataColumn("截止報名"),
                new DataColumn("開始日期"),
                new DataColumn("結束日期"),
            };
            foreach (DataColumn dc in dcBatch)
            {
                dsBatch.Columns.Add(dc.ColumnName);
            }

            for (int i = 0; i < Convert.ToInt32(BatchValue.Value); i++)
            {
                DataRow dr = dsBatch.NewRow();
                dr["批次"] = i + 1;
                dr["開放報名"] = _RegStartD[i];
                dr["截止報名"] = _RegEndD[i];
                dr["開始日期"] = _ActStartD[i];
                dr["結束日期"] = _ActEndD[i];
                dsBatch.Rows.Add(dr);
            }
            dataGridView1.DataSource = dsBatch;
            dataGridView1.RowHeadersWidth = 4;
            dataGridView1.Columns["批次"].ReadOnly = true;
            dataGridView1.Columns["批次"].Width = 50;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;
        }

        private void BatchValue_ValueChanged(object sender, EventArgs e)
        {
            recordDate();
            ActBatchDate();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            recordDate();
        }

        /// <summary>
        /// 紀錄資料表時實資料，將List尺寸調整為與批次數相同
        /// </summary>
        private void recordDate()
        {
            if (_ActStartD == null || _ActEndD == null || _RegStartD == null || _RegEndD == null)
            {
                _ActStartD = new List<string>();
                _ActEndD = new List<string>();
                _RegStartD = new List<string>();
                _RegEndD = new List<string>();
            }      
            
            for (int i = 0; i < BatchValue.Value; i++)
            {
                if (i < _ActStartD.Count)
                {
                    DataTable dt = dataGridView1.DataSource as DataTable;
                    _RegStartD[i] = dt.Rows[i]["開放報名"].ToString();
                    _RegEndD[i] = dt.Rows[i]["截止報名"].ToString();
                    _ActStartD[i] = dt.Rows[i]["開始日期"].ToString();
                    _ActEndD[i] = dt.Rows[i]["結束日期"].ToString();
                }
                else
                {
                    _ActStartD.Add("");
                    _ActEndD.Add("");
                    _RegStartD.Add("");
                    _RegEndD.Add("");
                }
            }
            while (BatchValue.Value < _ActStartD.Count)
            {
                _ActStartD.RemoveAt(_ActStartD.Count - 1 );
                _ActEndD.RemoveAt(_ActEndD.Count - 1);
                _RegStartD.RemoveAt(_RegStartD.Count - 1);
                _RegEndD.RemoveAt(_RegEndD.Count - 1);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "活動圖片(*.png)|*.png|活動圖片(*.jpg)|*.jpg|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) //沒有這行的話，檔案選取器會秒開關
                return;
            Image img = Bitmap.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = img;

            FileStream imgStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(imgStream);
            activity.fActImg = reader.ReadBytes((int)imgStream.Length);
            reader.Close();
            imgStream.Close();
        }

        private void btnCancelAct_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("取消不儲存", "確認訊息", MessageBoxButtons.OKCancel);
            if (s == DialogResult.OK)
            {
                _isOk = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnSaveAct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(checkFoemat()))
            {
                MessageBox.Show(checkFoemat(), "資料驗證");
                return;
            }
            for (int i = 0; i < _ActStartD.Count(); i++)
            {
                if (Convert.ToDateTime(_RegStartD[i]) < DateTime.Now && Convert.ToDateTime(_ActEndD[i]) > DateTime.Now && btnStatusT.Checked == false)
                {
                    MessageBox.Show("活動進行期間，不可下架活動");
                    btnStatusT.Checked = true;
                    return;
                }
            }
            _isOk = DialogResult.OK;
            this.Close();
        }

        private string checkFoemat()
        {
            string msgerr = "";
            if (string.IsNullOrEmpty(txtActName.fTxtBoxValue))
                msgerr += "請填寫活動名稱\r\n";
            if(string.IsNullOrEmpty(txtActlocation.fTxtBoxValue))
                msgerr += "請填寫活動地點\r\n";
            if (string.IsNullOrEmpty(txtActlocation.fTxtBoxValue))
                msgerr += "請填寫報名費用\r\n";
            if (!int.TryParse(txtActFee.fTxtBoxValue, out _))
                msgerr += "報名費用須為數字\r\n";
            if (string.IsNullOrEmpty(txtActNMax.fTxtBoxValue))
                msgerr += "請填寫人數上限\r\n";
            if (!int.TryParse(txtActNMax.fTxtBoxValue, out _))
                msgerr += "報名費用人數上限\r\n";
            DataTable dt = dataGridView1.DataSource as DataTable;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!DateTime.TryParse(_RegStartD[i], out _) || !DateTime.TryParse(_RegEndD[i], out _) || !DateTime.TryParse(_ActStartD[i], out _) || !DateTime.TryParse(_ActEndD[i], out _))
                    msgerr += "請填寫活動日期表\r\n 格式 : yyyy/MM/dd\r\n";
                break;
            }

            return msgerr;
        }

        private void btnCloseAct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(checkFoemat()))
            {
                MessageBox.Show(checkFoemat(), "資料驗證");
                return;
            }
            for (int i = 0; i < _ActStartD.Count(); i++)
            {
                if (Convert.ToDateTime(_RegStartD[i]) < DateTime.Now && Convert.ToDateTime(_ActEndD[i]) > DateTime.Now && btnStatusT.Checked == false)
                {
                    MessageBox.Show("活動進行期間，不可下架活動");
                    btnStatusT.Checked = true;
                    return;
                }
            }
            foreach (string d in _ActEndD)
            {
                if (Convert.ToDateTime(d) > DateTime.Now)
                {
                    MessageBox.Show("活動尚未結束，不可結案");
                    return ;
                }
            }            
            _isOk = DialogResult.OK;
            _activity.fActClosed = DateTime.Now.ToString("yyyy/MM/dd");
            this.Close();
        }
    }
}
