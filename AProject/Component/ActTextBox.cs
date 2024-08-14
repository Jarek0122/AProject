using AProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AProject.Component
{
    public partial class ActTextBox : UserControl
    {
        public ActTextBox()
        {
            InitializeComponent();            
        }

        public float fTextSize
        {
            get { return label1.Font.Size; }
            set
            {
                label1.Font = new Font(label1.Font.FontFamily, value);
                textBox1.Font = new Font(label1.Font.FontFamily, value);                
            }
        }

        public HorizontalAlignment fTextAlign
        {
            get { return textBox1.TextAlign; }
            set { textBox1.TextAlign = value; }
        }

        public int fLabelWidth
        {
            get { return label1.Width; }
            set
            {
                label1.Width = value;
                label1.Height = textBox1.Height;
                this.Width = label1.Width + textBox1.Width;
            }
        }

        public bool fEnable
        {
            get { return textBox1.Enabled; }
            set 
            {
                label1.Enabled = true;
                textBox1.Enabled = value; 
            }
        }

        public bool fVisiable
        {
            get { return label1.Visible; }
            set
            {
                textBox1.Visible = value;
                label1.Visible = value;
            }
        }

        public string fLabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string fTxtBoxValue
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void label1_Layout(object sender, LayoutEventArgs e)
        {
            label1.Size = new Size (100,textBox1.Height);
            this.Size = new System.Drawing.Size(this.Width, textBox1.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(CboxClick!=null)
                CboxClick(this, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (CboxClick != null) //bug進不來
                CboxClick(this, e);
        }
        public event Dbox CboxClick;
    }
        public delegate void Dbox(object sender, EventArgs e);
}
