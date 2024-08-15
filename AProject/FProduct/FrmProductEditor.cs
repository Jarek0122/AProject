using AProject.CProduct;
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

namespace AProject.FProduct
{
    public partial class FrmProductEditor : Form
    {
        public FrmProductEditor()
        {
            InitializeComponent();
        }
        public string title
        {
            get { return lblProdTitle.Text; }
            set { lblProdTitle.Text = value; }
        }
        public DialogResult isOK { get; set; }
        private CProd _product = null;
        public CProd product
        {
            get {
                if (_product == null)
                    _product = new CProd();
                _product.fProdName=fbProdName.Text;
                _product.fProdDescription=fbProdDescription.Text;
                _product.fProdPrice=Convert.ToDecimal(fbProdPrice.Text);
                return _product; }
            set {
                _product = value;
                fbProdName.Text = _product.fProdName.ToString();
                fbProdDescription.Text = _product.fProdDescription.ToString();
                fbProdPrice.Text=_product.fProdPrice.ToString();
                if (_product.fProdImage != null)
                {
                    Stream streamImage=new MemoryStream(_product.fProdImage);
                    pictureBox1.Image=Bitmap.FromStream(streamImage);
                }
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "產品海報|*.png|電影海報|*.jpg|電影海報|*.bmp";
            if(openFileDialog1.ShowDialog()!=DialogResult.OK)
                return;
            Image img = Bitmap.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = img;

            FileStream imgStram= new FileStream(openFileDialog1.FileName,
                FileMode.Open, FileAccess.Read);
            BinaryReader reader= new BinaryReader(imgStram);
            this.product.fProdImage=reader.ReadBytes((int)imgStram.Length);
            reader.Close();
            imgStram.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (string.IsNullOrEmpty(fbProdName.Text))
                errMsg += "\r\n名稱必須輸入";
            if (string.IsNullOrEmpty(fbProdPrice.Text))
                errMsg += "\r\n價格必須輸入";
            if (string.IsNullOrEmpty(fbProdDescription.Text))
                errMsg += "\r\n描述必須輸入";
            if (!CNumberUtility.isNumber(fbProdPrice.Text))
                errMsg += "\r\n價格必須輸入整數";
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            this.isOK = DialogResult.OK;
            Close();
        }
    }
}
