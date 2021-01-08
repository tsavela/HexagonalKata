using Api.DTOs;
using Core.InboundPorts;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PurchaseController : ControllerBase
    {
        private readonly PurchaseService _purchaseService;

        public PurchaseController(PurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }

        [HttpPost("{quantity}")]
        public OrderDto Purchase(int quantity)
        {
            var order = _purchaseService.Purchase(quantity);
            return order.Adapt<OrderDto>();
        }
    }
}