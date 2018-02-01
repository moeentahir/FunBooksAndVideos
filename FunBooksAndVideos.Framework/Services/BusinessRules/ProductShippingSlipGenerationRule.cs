using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    public class ProductShippingSlipGenerationRule : IBusinessRule<PurchaseOrder>
    {
        public bool WasActionSuccessfullyPerformed { get; set; }

        public bool IsApplicable(PurchaseOrder businessObject) => businessObject.Items.OfType<Product>().Any();

        public void PerfromAction(PurchaseOrder businessObject)
        {
            // write code here to activate the membership
            WasActionSuccessfullyPerformed = true;
        }
    }
}
