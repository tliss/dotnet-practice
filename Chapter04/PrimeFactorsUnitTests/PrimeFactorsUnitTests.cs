using PrimeFactorsLib;
using Xunit;

namespace PrimeFactorsUnitTests
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void TestFindFactors30()
        {
            int a = 30;
            string expected = "2 x 3 x 5 x ";

            var fact = new PrimeFactors();
            string actual = fact.FindFactors(a);
            Assert.Equal(expected, actual);
        }
    }
}
