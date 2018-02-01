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
        public void Process_With_No_Rules()
        {
            var bookWithoutRules = new Product("The Girl on the train", ProductType.Book, Enumerable.Empty<IRule<Product>>());
            var purchaseOrder = new PurchaseOrder()
            {
                ID = 3344656,
                CustomerId = 4567890,
                Total = 48.50M,
                ItemLines = new List<Commodity>
                {
                    bookWithoutRules
                }
            };

            var processor = new PurchaseOrderProcessor(purchaseOrder);

            processor.Process();

        }

        [TestMethod]
        public void Only_Product_Rule_Runs()
        {

            var emailRule = new Mock<IRule<Product>>();

            var bookWithemailRule = new Product("The Girl on the train", ProductType.Book, new List<IRule<Product>> { new ProductShippingSlipGenerationRule() } );
            var purchaseOrder = new PurchaseOrder()
            {
                ID = 3344656,
                CustomerId = 4567890,
                Total = 48.50M,
                ItemLines = new List<Commodity>
                {
                    bookWithemailRule
                }
            };

            var processor = new PurchaseOrderProcessor(purchaseOrder);

            processor.Process();

            emailRule.Verify(r => r.Run(bookWithemailRule));

        }
    }
}
