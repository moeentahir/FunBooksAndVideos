﻿using System;
using System.Collections.Generic;
using FunBooksAndVideos.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunBooksAndVideos.UnitTests
{
    [TestClass]
    public class MembershipActivationRuleTests
    {
        [TestMethod]
        public void Empty_Purchase_Order_Should_Not_Call_This_Rule()
        {
            var expected = false;
            var purchaseOrder = new PurchaseOrder();

            var rule = new MembershipActivationRule();

            var actual = rule.IsApplicable(purchaseOrder);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Purchase_Order_With_Product_Should_Not_Call_This_Rule()
        {
            var expected = false;
            var purchaseOrder = new PurchaseOrder()
            {
                Items = new List<PurchasableItem>
                {
                     new Book()
                }
            };

            var rule = new MembershipActivationRule();

            var actual = rule.IsApplicable(purchaseOrder);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Purchase_Order_With_Membership_Should_Call_This_Rule()
        {
            var expected = true;
            var purchaseOrder = new PurchaseOrder()
            {
                Items = new List<PurchasableItem>
                {
                     new Membership()
                }
            };

            var rule = new MembershipActivationRule();

            var actual = rule.IsApplicable(purchaseOrder);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Purchase_Order_With_Membership_And_Products_Should_Call_This_Rule()
        {
            var expected = true;
            var purchaseOrder = new PurchaseOrder()
            {
                Items = new List<PurchasableItem>
                {
                    new Book(),
                    new Membership(),
                    new Video()
                }
            };

            var rule = new MembershipActivationRule();

            var actual = rule.IsApplicable(purchaseOrder);

            Assert.AreEqual(expected, actual);
        }
    }
}
