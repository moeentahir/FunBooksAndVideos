using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunBooksAndVideos.Framework;

namespace FunBooksAndVideos.UnitTests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void Verify_Display()
        {
            var book = new Book { Name = "The Girl on the train" };
            var actual = book.ToString();
            var expected = "Book \"The Girl on the train\"";

            Assert.AreEqual(expected, actual);
        }
    }
}
