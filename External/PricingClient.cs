using Core.OutboundPorts;

namespace External
{
    public class PricingClient : IPricingClient
    {
        public decimal GetPriceForItem()
        {
            return 123;
        }
    }
}