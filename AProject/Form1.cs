﻿using System;
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

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            FAd.Floading newForm = new FAd.Floading();
            newForm.Show();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }
    }
}
