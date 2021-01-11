using Core.Domain;
using Core.OutboundPorts;

namespace External
{
    public class PricingClient : IPricingClient
    {
        public ItemPrice GetPriceForItem()
        {
            return 123;
        }
    }
}