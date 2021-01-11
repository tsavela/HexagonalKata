using System;

namespace Core.Domain
{
    public class ItemPrice
    {
        public decimal Value { get; }

        public ItemPrice(decimal itemPrice)
        {
            if (itemPrice < 0)
                throw new ArgumentException("Invalid item price", nameof(itemPrice));

            Value = itemPrice;
        }

        public static implicit operator decimal(ItemPrice quantity) => quantity.Value;
        public static implicit operator ItemPrice(int quantity) => new ItemPrice(quantity);
    }
}