using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace direktoriMember.Models
{
    public class SOLine
    {
        public int SOLineID { get; set; }

        public int Quantity { get; set; }

        //lookup produk
        public int ProdukID { get; set; }
        public Produk Produk { get; set; }

        public int SOHeaderID { get; set; }
        public SOHeader SOHeader { get; set; }
    }
}
