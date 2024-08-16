using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AProject.FAd
{
    public partial class Floading : Form
    {
        public Floading()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adadd_Click(object sender, EventArgs e)
        {

        }
        int startpos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            myprogressBar.Value = startpos;
            run.Text = startpos + "%";
            if(myprogressBar.Value ==100)
            {
                myprogressBar.Value = 0;
                timer1.Stop();
                FrmAdverTisement f = new FrmAdverTisement();
                f.Show();
                this.Hide();


            }
        }

        private void Floading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
