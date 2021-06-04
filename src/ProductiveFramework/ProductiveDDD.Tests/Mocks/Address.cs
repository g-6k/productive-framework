using System.Collections.Generic;

namespace ProductiveDDD.Tests.Mocks
{
    internal class Address : ValueObject
    {
        public Address(string street, string city, int number)
        {
            Street = street;
            City = city;
            Number = number;
        }

        public string City { get; }

        public int Number { get; }

        public string Street { get; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Street;
            yield return Number;
            yield return City;
        }
    }
}