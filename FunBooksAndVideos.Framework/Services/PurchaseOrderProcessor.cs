using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    public class PurchaseOrderProcessor
    {
        public PurchaseOrder PurchaseOrder { get; }

        public PurchaseOrderProcessor(PurchaseOrder purchaseOrder)
        {
            PurchaseOrder = purchaseOrder;
        }


        public bool Process()
        {
            var allRules = PurchaseOrder.ItemLines;

            foreach (var item in allRules)
            {
                item.RunPostProcessingRules();
            }

            return true;
        }
    }
}
