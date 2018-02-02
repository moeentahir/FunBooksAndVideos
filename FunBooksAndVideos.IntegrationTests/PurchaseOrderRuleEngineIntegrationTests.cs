using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunBooksAndVideos.Framework;
using System.Collections.Generic;
using Moq;
using System.Linq;

namespace FunBooksAndVideos.IntegrationTests
{
    [TestClass]
    public class PurchaseOrderRuleEngineIntegrationTests
    {
        [TestMethod]
        public void PO_With_Product_Only_Runs_Product_Rule_Only()
        {
            var purchaseOrder = new PurchaseOrder()
            {
                ID = 3344656,
                CustomerId = 4567890,
                Total = 48.50M,
                Items = new List<PurchasableItem>
                {
                    new Book { Name = "The Girl on the train"}
                }
            };

            var ruleEngine = new PurchaseOrderRuleEngine();
            var processor = new PurchaseOrderProcessor(purchaseOrder, ruleEngine);

            processor.Process();

            var productRuleResult = ruleEngine.Rules.OfType<ProductShippingSlipGenerationRule>().All(r => r.WasActionSuccessfullyPerformed);
            var membershipRuleResult = ruleEngine.Rules.OfType<MembershipActivationRule>().All(r => r.WasActionSuccessfullyPerformed);

            Assert.AreEqual(true, productRuleResult);
            Assert.AreEqual(false, membershipRuleResult);
        }

        [TestMethod]
        public void PO_With_Membership_Only_Runs_Membership_Rule_Only()
        {
            var purchaseOrder = new PurchaseOrder()
            {
                ID = 3344656,
                CustomerId = 4567890,
                Total = 48.50M,
                Items = new List<PurchasableItem>
                {
                    new Membership { Type = MembershipType.Premium }
                }
            };

            var ruleEngine = new PurchaseOrderRuleEngine();
            var processor = new PurchaseOrderProcessor(purchaseOrder, ruleEngine);

            processor.Process();

            var productRuleResult = ruleEngine.Rules.OfType<ProductShippingSlipGenerationRule>().All(r => r.WasActionSuccessfullyPerformed);
            var membershipRuleResult = ruleEngine.Rules.OfType<MembershipActivationRule>().All(r => r.WasActionSuccessfullyPerformed);

            Assert.AreEqual(false, productRuleResult);
            Assert.AreEqual(true, membershipRuleResult);
        }

        [TestMethod]
        public void PO_With_Product_And_Membership_Should_Run_Both_Rules()
        {
            var purchaseOrder = new PurchaseOrder()
            {
                ID = 3344656,
                CustomerId = 4567890,
                Total = 48.50M,
                Items = new List<PurchasableItem>
                {
                    new Membership { Type = MembershipType.Premium },
                    new Book { Name= "The Girl on the train" },
                    new Video { Name= "Comprehensive First Aid Training" }
                }
            };

            var ruleEngine = new PurchaseOrderRuleEngine();
            var processor = new PurchaseOrderProcessor(purchaseOrder, ruleEngine);

            processor.Process();

            var productRuleResult = ruleEngine.Rules.OfType<ProductShippingSlipGenerationRule>().All(r => r.WasActionSuccessfullyPerformed);
            var membershipRuleResult = ruleEngine.Rules.OfType<MembershipActivationRule>().All(r => r.WasActionSuccessfullyPerformed);

            Assert.AreEqual(true, productRuleResult);
            Assert.AreEqual(true, membershipRuleResult);
        }
    }
}
