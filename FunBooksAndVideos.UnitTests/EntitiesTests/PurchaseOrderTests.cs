using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunBooksAndVideos.Framework;
using System.Collections.Generic;

namespace FunBooksAndVideos.UnitTests
{
    [TestClass]
    public class PurchaseOrderTests
    {
        [TestMethod]
        public void Whatever_You_Set_Is_What_You_Get()
        {
            var purchaseOrder = new PurchaseOrder()
            {
                ID = 3344656,
                CustomerId = 4567890,
                Total = 48.50M,
                Items = new List<PurchasableItem>
                {
                    new Book { Name = "The Girl on the train"},
                    new Video { Name = "Comprehensive First Aid Training"},
                    new Membership{ Type=MembershipType.Book }
                }
            };

            Assert.AreEqual(3344656, purchaseOrder.ID);
            Assert.AreEqual(4567890, purchaseOrder.CustomerId);
            Assert.AreEqual(48.50M, purchaseOrder.Total);
            Assert.AreEqual(3, purchaseOrder.Items.Count);
        }
    }
}
