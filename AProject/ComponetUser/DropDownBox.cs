using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AProject.ComponetUser
{
    public partial class DropDownBox : UserControl
    {
        public DropDownBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string comboName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string comboValue
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }
    }
}
