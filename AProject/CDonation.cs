using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AProject.Models
{
    public class CDonation
    {
        public int fDonationId {  get; set; }


        public int fUserId { get; set; }
        public int fCompanyId { get; set; }


        public string fDonationDate { get; set; }
        public decimal fAmount { get; set; }
    }
}
