using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BabySitter.Library.Tests
{
    [TestFixture]
    public class SitterTests
    {
        [Test]
        public void Test_StartTimeToBedTimeCharge()
        {
            BabySitter.Library.Sitter babysitter = new BabySitter.Library.Sitter();
            Assert.AreEqual(48, babysitter.StartTimeToBedTimeCharge(4));
        }
        [Test]
        public void BedTimeToMidnightCharge_Rate()
        {
            Sitter babysitter = new Sitter();
            Assert.AreEqual(16, babysitter.BedTimeToMidnightCharge(2));
        }
        [Test]
        public void MidnightToEndTimeCharge_Rate()
        {
            Sitter babysitter = new Sitter();
            Assert.AreEqual(64, babysitter.MidnightToEndTimeCharge(4));
        }
        [Test]
        public void GetPayCharge_Return_Total_NightCharge()
        {
            Sitter babysitter = new Sitter();
            Assert.AreEqual(144, babysitter.getPayCharge("11 PM", "5 PM", "4 AM"));
        }
        [Test]
        public void GetPayCharge_Return_Total_NightCharge_Different_Times()
        {
            Sitter babysitter = new Sitter();
            Assert.AreEqual(132, babysitter.getPayCharge("8 PM", "6 PM", "3 AM"));
        }

    }
}
