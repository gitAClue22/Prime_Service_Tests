using System;
using Xunit;

namespace PrimeService.Tests
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }


        [Theory]
        [InlineData(2)]
        [InlineData(9)]
        [InlineData(16)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");


        }


        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(7)]
        public void IsPrime_ValuesLessThan2_ReturnTrue(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should not be prime");


        }
    }
}
