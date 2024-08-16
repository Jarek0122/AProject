using AProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AProject.Component
{
    public delegate void D(CAct a);
    public partial class ActBox : UserControl
    {
        public ActBox()
        {
            InitializeComponent();

        }

        public event D boxClick;
        public event D DoubleClick;
        private CAct _act; 
        public CAct act 
        {
            get { return _act; }
            set 
            {
                _act = value;
                boxActName.Text = _act.fActName;
                boxActLocation.Text = _act.fActLocation;
                boxActNMax.Text = _act.fActNMax.ToString();
                boxActFee.Text = _act.fActFee.ToString();
                boxActAccount.Text = _act.fUserId.ToString();
                boxActEditorD.Text = _act.fEditorDay.ToString("yyyy/MM/dd");
                boxActStatus.Text = (_act.fActStatus ? "公開" : "下架");
                boxActCloseD.Text = _act.fActClosed.ToString();
                if (_act.fActImg != null)
                {
                    Stream streamImg = new MemoryStream(_act.fActImg);
                    pictureBox1.Image = Bitmap.FromStream(streamImg);
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("批次");
                dt.Columns.Add("開始日期");
                dt.Columns.Add("結束日期");
                for (int i = 0; i < _act.fActStartD.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["批次"] = i + 1;
                    dr["開始日期"] = _act.fActStartD[i];
                    dr["結束日期"] = _act.fActEndD[i];
                    dt.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersWidth = 4;
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 85;
                dataGridView1.Columns[2].Width = 85;
            }
        }

        private void ActBox_Click(object sender, EventArgs e)
        {
            if (boxClick != null)
            {
                boxClick(this.act);
            }
        }

        private void ActBox_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                    foreach (Control d in c.Controls)
                    {
                        d.Click += ActBox_Click;
                    d.DoubleClick += ActBox_doubleClick;
                    }                
                c.Click += ActBox_Click;
            }
            
        }

        private void ActBox_doubleClick(object sender, EventArgs e)
        {
            if (DoubleClick != null)
            {
                DoubleClick(this.act);
            }
        }

        
    }
}
