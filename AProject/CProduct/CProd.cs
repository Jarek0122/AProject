using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AProject.CProduct
{
    public class CProd
    {
        public int fProdId { get; set; }
        public string fProdName { get; set; }
        public string fProdCat { get; set; }
        public string fProdDescription { get; set; }
        public decimal fProdPrice { get; set; }
        public int fProdStock { get; set; }
        public byte[] fProdImage { get; set; }
        
    }
}
