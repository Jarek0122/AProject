using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AProject.Model
{
    public class COrder
    {
        public int fOrderId { get; set; }
        public int fUserId { get; set; }
        public int fPromotionId { get; set; }

        public string fOrderDate { get; set;}
        public string fOrderStatus { get; set;}

        public bool fPaymentStatus { get; set;}
        public bool fShippingStatus { get; set;}
        public bool fServiceStatus { get; set;}
        public string fPaymentInfo { get; set;}
        public string fInvoiceInfo { get; set;}
        public string fRecepientName { get; set;}
        public string fRecepientAddress { get; set;}
        public string fRecepientPhone { get; set;}
        public string fRecepientEmail { get; set;}

        public string fOrderRemarks { get; set;}

        public string fShippingInfo { get; set;}
        public string fReturnInfo { get; set;}
    }
}
