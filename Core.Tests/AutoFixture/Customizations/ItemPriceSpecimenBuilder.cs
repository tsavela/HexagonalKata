using System;
using System.Reflection;
using AutoFixture.Kernel;
using Core.Domain;

namespace Core.Tests.AutoFixture.Customizations
{
    public class ItemPriceSpecimenBuilder : ISpecimenBuilder
    {
        private readonly Random _random = new Random();

        public object Create(object request, ISpecimenContext context)
        {
            if (request is ParameterInfo pi && pi.ParameterType == typeof(ItemPrice))
            {
                return new ItemPrice(_random.Next(1, 10000));
            }

            return new NoSpecimen();
        }
    }
}