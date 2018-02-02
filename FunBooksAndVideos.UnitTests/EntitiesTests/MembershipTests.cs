using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunBooksAndVideos.Framework;

namespace FunBooksAndVideos.UnitTests
{
    [TestClass]
    public class MembershipTests
    {
        [TestMethod]
        public void Verify_Book_Club_Membership_Display()
        {
            var book = new Membership { Type = MembershipType.Book };
            var actual = book.ToString();
            var expected = "Book Club Membership";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Verify_Video_Club_Membership_Display()
        {
            var book = new Membership { Type = MembershipType.Video };
            var actual = book.ToString();
            var expected = "Video Club Membership";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Verify_Premium_Club_Membership_Display()
        {
            var book = new Membership { Type = MembershipType.Premium };
            var actual = book.ToString();
            var expected = "Premium Club Membership";

            Assert.AreEqual(expected, actual);
        }
    }
}
