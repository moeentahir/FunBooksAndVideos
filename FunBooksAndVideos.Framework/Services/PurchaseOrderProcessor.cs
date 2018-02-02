using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    /// <summary>
    /// This class processes the purchase order and then runs the business rules after that 
    /// </summary>
    public class PurchaseOrderProcessor
    {
        public PurchaseOrder PurchaseOrder { get; }
        public IBusinessRuleEngine<PurchaseOrder> RuleEngine { get; }

        public PurchaseOrderProcessor(PurchaseOrder purchaseOrder, IBusinessRuleEngine<PurchaseOrder> ruleEngine)
        {
            PurchaseOrder = purchaseOrder;
            RuleEngine = ruleEngine;
        }

        /// <summary>
        /// After processing the purchase order, this method will run all the business rules as well
        /// </summary>
        public void Process()
        {
            // Step 1: Process the purchase order

            // Step 2: Run all the rules
            RuleEngine.Run(PurchaseOrder);
        }
    }
}
