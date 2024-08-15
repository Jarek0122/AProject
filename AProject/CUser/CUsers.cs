using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AProject.CUser
{
    public class CUsers
    {
        public int fId { get; set; }
        public string fEmail { get; set; }
        public string fPassword { get; set; }
        public string fName { get; set; }
        public string fPhone { get; set; }
        public string fGender { get; set; }
        public string fAddress { get; set; }
        public string fBirthdate { get; set; }
        public string fState { get; set; }
        public byte[] fImage { get; set; }
    }
}
