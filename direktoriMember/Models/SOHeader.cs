using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace direktoriMember.Models
{
    public class SOHeader
    {
        public SOHeader()
        {
            this.Tanggal = DateTime.UtcNow.Date;
        }
        public int SOHeaderID { get; set; }
        public DateTime Tanggal { get; set; }
        public string NamaMember { get; set; }

        //lookup Member
        public int MemberID { get; set; }
        public Member Member { get; set; }
    }
}
