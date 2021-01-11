using Core.Domain;

namespace Core.OutboundPorts
{
    public interface IPricingClient
    {
        ItemPrice GetPriceForItem();
    }
}