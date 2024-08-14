using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AProject.Models
{
    public class CAct
    {
        public int fActId { get;set; } //SQL產生
        public int fUserId { get;set; } //取自會員登入
        public DateTime fEditorDay { get;set; }
        public string fActName { get;set; }
        public string fActLocation { get;set; }
        public decimal fActFee { get;set; }
        public int fActNMax { get;set; }
        public int fActBatch { get;set; }
        public List<string> fActStartD { get;set; }
        public List<string> fActEndD { get;set; }
        public List<string> fRegStartD { get;set; }
        public List<string> fRegEndD { get;set; }
        public string fActSch { get;set; } //活動行程
        public string fActDescription { get;set; } //活動說明
        public string fActClosed { get;set; } //結案日期
        public bool fActStatus { get;set; } //活動狀態，false 0 下架/true 1 上架
        public byte[] fActImg { get;set; } 
        public int fImgId { get;set; } 
        public string fActImgDescription { get;set; } 
        //public List<byte[]> fActImg { get;set; } 
    }
}
