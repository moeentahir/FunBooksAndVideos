using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    public class MembershipActivationRule : IBusinessRule<PurchaseOrder>
    {
        public bool WasActionSuccessfullyPerformed { get; set; }

        public bool IsApplicable(PurchaseOrder purchaseOrder) => purchaseOrder.Items.OfType<Membership>().Any();

        public void PerfromAction(PurchaseOrder purchaseOrder)
        {
            // Activate the membership
            WasActionSuccessfullyPerformed = true;
        }
    }
}
