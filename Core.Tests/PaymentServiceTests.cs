using Core.Domain;
using Core.InboundPorts;
using Core.OutboundPorts;
using Core.Tests.AutoFixture;
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

        [Theory]
        [DomainAutoData]
        public void Purchase_ShouldReturnCorrectTotalPrice_WhenGivenValidQuantity(OrderQuantity quantity, ItemPrice itemPrice)
        {
            // Arrange
            var pricingServiceMock = Substitute.For<IPricingClient>();
            pricingServiceMock.GetPriceForItem().Returns(itemPrice);
            var sut = new PurchaseService(pricingServiceMock);

            // Act
            var actual = sut.Purchase(quantity);

            // Assert
            actual.TotalPrice.Should().Be(quantity * itemPrice);
        }
    }
}