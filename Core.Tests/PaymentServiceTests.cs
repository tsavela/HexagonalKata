using Core.InboundPorts;
using Core.OutboundPorts;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Core.Tests
{
    public class PaymentServiceTests
    {
        [Fact]
        public void Purchase_ShouldReturnOrder_WhenGivenValidQuantity()
        {
            // Arrange
            var pricingServiceMock = Substitute.For<IPricingClient>();
            var sut = new PurchaseService(pricingServiceMock);

            // Act
            var actual = sut.Purchase(1);

            // Assert
            actual.Should().NotBeNull();
        }

        [Fact]
        public void Purchase_ShouldReturnCorrectTotalPrice_WhenGivenValidQuantity()
        {
            // Arrange
            var pricingServiceMock = Substitute.For<IPricingClient>();
            pricingServiceMock.GetPriceForItem().Returns(100m);
            var sut = new PurchaseService(pricingServiceMock);

            // Act
            var actual = sut.Purchase(2);

            // Assert
            actual.TotalPrice.Should().Be(200);
        }
    }
}