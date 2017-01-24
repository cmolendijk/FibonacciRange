using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FibonacciRange.Tests
{
    public class FibonacciProviderTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(10)]
        public void GetRangeAmountTest(int amountOfNumbers)
        {
            var range = FibonacciProvider.GetRange(amountOfNumbers);
            Assert.Equal(amountOfNumbers, range.Length);
        }

        [Fact]
        public void ValidateRangeTest()
        {
            var range = FibonacciProvider.GetRange(10);

            Assert.Equal(10, range.Length);
            Assert.Equal(0, range[0]);
            Assert.Equal(1, range[1]);
            Assert.Equal(1, range[2]);
            Assert.Equal(2, range[3]);
            Assert.Equal(3, range[4]);
            Assert.Equal(5, range[5]);
            Assert.Equal(8, range[6]);
            Assert.Equal(13, range[7]);
            Assert.Equal(21, range[8]);
            Assert.Equal(34, range[9]);
        }

        [Fact]
        public void ValidateMathematicianRangeTest()
        {
            var range = FibonacciProvider.GetRange(10, true);

            Assert.Equal(10, range.Length);
            Assert.Equal(1, range[0]);
            Assert.Equal(2, range[1]);
            Assert.Equal(3, range[2]);
            Assert.Equal(5, range[3]);
            Assert.Equal(8, range[4]);
            Assert.Equal(13, range[5]);
            Assert.Equal(21, range[6]);
            Assert.Equal(34, range[7]);
            Assert.Equal(55, range[8]);
            Assert.Equal(89, range[9]);
        }
    }
}
