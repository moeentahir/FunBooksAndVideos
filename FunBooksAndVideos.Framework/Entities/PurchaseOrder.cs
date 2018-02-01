using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    public class PurchaseOrder
    {
        public int ID { get; set; }

        public int CustomerId { get; set; }

        public decimal Total { get; set; }

        public List<PurchaseOrderItem> Items { get; set; }

        public PurchaseOrder()
        {
            Items = new List<PurchaseOrderItem>();
        }
    }
}
