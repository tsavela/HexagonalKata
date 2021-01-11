using System;
using AutoFixture;
using AutoFixture.Xunit2;
using Core.Tests.AutoFixture.Customizations;

namespace Core.Tests.AutoFixture
{
    public class DomainAutoDataAttribute : AutoDataAttribute
    {
        public DomainAutoDataAttribute()
            : base(GetFixtureFactory())
        {

        }

        private static Func<IFixture> GetFixtureFactory()
        {
            return () =>
            {
                var fixture = new Fixture();
                fixture.Customizations.Add(new BookingNumberSpecimenBuilder());
                fixture.Customizations.Add(new ItemPriceSpecimenBuilder());
                return fixture;
            };
        }
    }
}