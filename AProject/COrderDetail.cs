using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AProject.Models
{
    public class COrderDetail
    {
        public int fOrderDetailId { get; set; }


        public int fOrderId { get; set; }
        public int fProductId { get; set; }



        public int fQuantity { get; set; }
        public decimal fPrice { get; set; }
        public string fReviewDate { get; set; }
        public int fReviewScore { get; set; }
        public string fProductReview {  get; set; }
    }
}
