using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunBooksAndVideos.Framework;

namespace FunBooksAndVideos.UnitTests
{
    [TestClass]
    public class VideoTests
    {
        [TestMethod]
        public void Verify_Display()
        {
            var book = new Video { Name = "Comprehensive First Aid Training" };
            var actual = book.ToString();
            var expected = "Video \"Comprehensive First Aid Training\"";

            Assert.AreEqual(expected, actual);
        }
    }
}
