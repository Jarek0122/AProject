using AProject.View;
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
        FrmActManager fAM;
        FrmActRecord fAR;
        public Form1()
        {
            InitializeComponent();
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

        private void 活動上架ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fAM != null && !fAM.IsDisposed)
            {
                fAM.Activate();
            }
            else
            {
                fAM = new FrmActManager()
                {
                    MdiParent = this
                };
                fAM.Show();
            }
        }

        private void 活動訂單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fAR != null && !fAR.IsDisposed)
            {
                fAR.Activate();
            }
            else
            {
                fAR = new FrmActRecord
                {
                    MdiParent= this
                };
                fAR.Show();
            }
        }
    }
}
