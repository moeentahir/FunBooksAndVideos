using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunBooksAndVideos.Framework;
using System.Collections.Generic;
using System.Linq;
using Moq;

namespace FunBooksAndVideos.UnitTests
{
    [TestClass]
    public class PurchaseOrderProcessorTests
    {
        [TestMethod]
        public void Verify_Rule_Engine_Is_Called_After_Processing_PO()
        {
            var purchaseOrder = new PurchaseOrder()
            {
                ID = 3344656,
                CustomerId = 4567890,
                Total = 48.50M,
                Items = new List<PurchaseOrderItem>
                {
                    new Product { Name = "The Girl on the train", Type = ProductType.Book }
                }
            };

            var ruleEngine = new Mock<IRuleEngine<PurchaseOrder>>();
            var processor = new PurchaseOrderProcessor(purchaseOrder, ruleEngine.Object);

            processor.Process();

            ruleEngine.Verify(r => r.Run(purchaseOrder), Times.Once);
        }
    }
}
