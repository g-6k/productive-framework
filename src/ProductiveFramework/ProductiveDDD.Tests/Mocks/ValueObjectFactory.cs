using System.Collections.Generic;

namespace ProductiveDDD.Tests.Mocks
{
    internal static class ValueObjectFactory
    {
        public static AddressBook HeavenAddressBook()
        {
            return new AddressBook("Heaven", new List<Address> { StairwayToHeaven(), Nowhere() });
        }

        public static AddressBook HellAddressBook()
        {
            return new AddressBook("Hell", new List<Address> { HighwayToHellAddress(), Nowhere() });
        }

        public static Address HighwayToHellAddress()
        {
            return new Address("Highway to hell", "Hell", 666);
        }

        public static Address Nowhere()
        {
            return new Address("Nowhere", "Void", 0);
        }

        public static Address StairwayToHeaven()
        {
            return new Address("Stairway to heaven", "Heaven", 42);
        }
    }
}