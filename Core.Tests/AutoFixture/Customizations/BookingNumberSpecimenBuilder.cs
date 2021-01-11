using System;
using System.Reflection;
using AutoFixture.Kernel;
using Core.Domain;

namespace Core.Tests.AutoFixture.Customizations
{
    public class BookingNumberSpecimenBuilder : ISpecimenBuilder
    {
        private readonly Random _random = new Random();

        public object Create(object request, ISpecimenContext context)
        {
            if (request is ParameterInfo pi && pi.ParameterType == typeof(OrderQuantity))
            {
                return new OrderQuantity(_random.Next(1, 1000));
            }

            return new NoSpecimen();
        }
    }
}