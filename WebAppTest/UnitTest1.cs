using System;
using Xunit;

namespace WebAppTest
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        [Fact]
        public void Kot()
        {

        }
    }
}
