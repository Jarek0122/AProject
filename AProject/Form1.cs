using AProject.Views;
using AProject.FUser;
using AProject.FOrder;
using AProject.FMatch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            toolStrip1.Width = Width * 182 / 1152;
            foreach (ToolStripItem b in toolStrip1.Items)
            {
                if (b is ToolStripButton button)
                {
                    b.Size = new Size(Width * 180 / 1152, Height * 32 / 648);
                }
            }
        }


        private void 會員偏好維護ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPreferMainten f = new FrmPreferMainten();
            f.MdiParent = this;
            f.Show(); // 打開會員偏好維護 Form
        }

        private void 自動配對管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutoMatch f = new FrmAutoMatch();
            f.MdiParent = this;
            f.Show(); // 打開自動配對管理 Form
        }

        private void 配對狀態查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStatusCheck f = new FrmStatusCheck();
            f.MdiParent = this;
            f.Show();// 打開配對狀態查看 Form
        }

        private void 會員管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser u = new FrmUser();
            u.MdiParent = this;
            u.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            (new FrmLogin()).ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            FrmOrderManager f = new FrmOrderManager();
            f.MdiParent = this;
            f.Show();
        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {
            FrmProductList f= new FrmProductList();
            f.MdiParent = this;
            f.Show();
        }
    }
}
