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
        public IRuleEngine<PurchaseOrder> RuleEngine { get; }

        public PurchaseOrderProcessor(PurchaseOrder purchaseOrder, IRuleEngine<PurchaseOrder> ruleEngine)
        {
            PurchaseOrder = purchaseOrder;
            RuleEngine = ruleEngine;
        }

        public void Process()
        {
            // Step 1: Process the purchase order

            // Step 2: Run all the rules
            RuleEngine.Run(PurchaseOrder);
        }
    }
}
