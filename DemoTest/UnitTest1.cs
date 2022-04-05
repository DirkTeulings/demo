using System;
using Xunit;

namespace DemoTest
{
    public class DemoTests
    {
        /// <summary>
        /// is true actually true
        /// </summary>
        [Fact]
        public void IsTrueTrue()
        {
            Assert.True(true);
        }

        /// <summary>
        /// is false actually false
        /// </summary>
        [Fact]
        public void IsFalseFalse()
        {
            Assert.False(false);
        }

        /// <summary>
        /// wonkey test
        /// </summary>
        [Fact]
        public void Wonkey()
        {
            var val = true;

            if (true == val)
                if (!true == !val)
                    if (!false == val)
                    {
                        Assert.True(val);
                        return;
                    }
                        

            Assert.False(val);

        }
    }
}
