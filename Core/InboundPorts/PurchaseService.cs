using Core.Domain;
using Core.OutboundPorts;

namespace Core.InboundPorts
{
    public class PurchaseService
    {
        private readonly IPricingClient _pricingClient;

        public PurchaseService(IPricingClient pricingClient)
        {
            _pricingClient = pricingClient;
        }

        public Order Purchase(OrderQuantity quantity)
        {
            var pricePerItem = _pricingClient.GetPriceForItem();
            return new Order(pricePerItem * quantity);
        }
    }
}