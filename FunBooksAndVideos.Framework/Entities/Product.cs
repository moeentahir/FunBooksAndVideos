using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    public class Product : PurchaseOrderItem
    {
        public ProductType Type { get; set; }
    }
}
