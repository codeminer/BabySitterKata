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
    }
}
