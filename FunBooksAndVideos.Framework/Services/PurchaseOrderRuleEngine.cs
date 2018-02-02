using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    public class PurchaseOrderRuleEngine : IBusinessRuleEngine<PurchaseOrder>
    {
        public List<IBusinessRule<PurchaseOrder>> Rules { get; }

        public PurchaseOrderRuleEngine()
        {
            Rules = new List<IBusinessRule<PurchaseOrder>>
            {
                new ProductShippingSlipGenerationRule(),
                new MembershipActivationRule()
            };
        }

        public void Run(PurchaseOrder purchaseOrder)
        {
            foreach (var rule in Rules)
            {
                if (rule.IsApplicable(purchaseOrder))
                    rule.PerfromAction(purchaseOrder);
            }
        }
    }
}
