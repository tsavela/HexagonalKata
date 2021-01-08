using System;

namespace Core.Domain
{
    public class OrderQuantity
    {
        public int Value { get; }

        public OrderQuantity(int quantity)
        {
            if (quantity < 1 || quantity > 1000)
                throw new ArgumentException("Invalid order quantity", nameof(quantity));

            Value = quantity;
        }

        public static implicit operator int(OrderQuantity quantity) => quantity.Value;
        public static implicit operator OrderQuantity(int quantity) => new OrderQuantity(quantity);
    }
}