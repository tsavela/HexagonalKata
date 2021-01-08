using System;
using FluentAssertions;
using Xunit;

namespace External.Tests
{
    public class PricingClientTests
    {
        [Fact]
        public void GetPriceForItem_ShouldReturnValueWithinRange_WhenCalled()
        {
            // Arrange
            var sut = new PricingClient();

            // Act
            var actual = sut.GetPriceForItem();

            // Assert
            actual.Should().BePositive();
        }
    }
}