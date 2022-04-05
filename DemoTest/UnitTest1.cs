using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DemoTest
{
    [TestClass]
    public class DemoTests
    {
        /// <summary>
        /// is true actually true
        /// </summary>
        [TestMethod]
        public void IsTrueTrue()
        {
            Assert.IsTrue(true);
        }

        /// <summary>
        /// is false actually false
        /// </summary>
        [TestMethod]
        public void IsFalseFalse()
        {
            Assert.IsFalse(false);
        }

        /// <summary>
        /// wonkey test
        /// </summary>
        [TestMethod]
        public void Wonkey()
        {
            var val = true;

            if (true == val)
                if (!true == !val)
                    if (!false == val)
                    {
                        Assert.IsTrue(val);
                        return;
                    }
                        

            Assert.IsFalse(val);

        }
    }
}
