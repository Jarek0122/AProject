using AProject.ComponetUser;
using AProject.CUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AProject.FUser
{
    public partial class FrmUserEditor : Form
    {
        private CUsers _users = null;
        public FrmUserEditor()
        {
            InitializeComponent();
        }
        private void FrmUserEditor_Load(object sender, EventArgs e)
        {
            dtpBirthdate.Format = DateTimePickerFormat.Custom;
            dtpBirthdate.CustomFormat = "yyyy/MM/dd";

            // 設定最後可選取日期為今天
            dtpBirthdate.MaxDate = DateTime.Today;
        }
        public string title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public DialogResult isok { get; set; }
        public CUsers users 
        { 
            get 
            { 
                if (_users == null) 
                    _users = new CUsers();
                _users.fEmail = fbEmail.fieldValue;
                _users.fPassword = fbPassword.fieldValue;             
                _users.fName = fbName.fieldValue;
                _users.fPhone = fbPhone.fieldValue;
                _users.fGender = cbGender.Text;
                _users.fAddress = fbAddress.fieldValue;
                _users.fBirthdate = dtpBirthdate.Value.ToString("yyyy-MM-dd");
                _users.fState = cbstate.Text;
                return _users; 
            }
            set 
            {
                _users = value;
                fbEmail.fieldValue = _users.fEmail.ToString();
                fbPassword.fieldValue = _users.fPassword.ToString();
                fbName.fieldValue = _users.fName.ToString();
                fbPhone.fieldValue = _users.fPhone.ToString();
                cbGender.Text = _users.fGender;
                fbAddress.fieldValue = _users.fAddress.ToString();
                if (DateTime.TryParse(_users.fBirthdate, out DateTime birthDate))
                {
                    dtpBirthdate.Value = birthDate;
                }
                else
                {
                    dtpBirthdate.Value = DateTime.Today;
                }
                cbstate.Text = _users.fState;
                if (_users.fImage != null)
                {
                    Stream streamImage = new MemoryStream(_users.fImage);
                    pictureBox1.Image = Bitmap.FromStream(streamImage);
                }
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool isNumber(string p)
        {
            try
            {
                double d = Convert.ToDouble(p);
                return true;
            }
            catch 
            { 
                return false; 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is FieldBox)
                {
                    FieldBox tb = (FieldBox)ctrl;
                    if (string.IsNullOrWhiteSpace(tb.fieldValue))
                    {
                        MessageBox.Show("所有資料必須填寫！");
                        return;
                    }
                }
            }
            string errMsg = "";
            if (!isNumber(fbPhone.fieldValue))
                errMsg += "\r\n電話必須輸入數字";
            if(!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            this.isok = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "電影海報|*.png|電影海報|*.jpg|電影海報|*.bmp";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            Image img = Bitmap.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = img;

            FileStream imgStram = new FileStream(openFileDialog1.FileName,
                FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(imgStram);
            this.users.fImage = reader.ReadBytes((int)imgStram.Length);
            reader.Close();
            imgStram.Close();
        }
    }
}
