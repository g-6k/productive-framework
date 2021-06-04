using System.Collections.Generic;
using System.Linq;

namespace ProductiveDDD.Tests.Mocks
{
    internal class AddressBook : ValueObject
    {
        public AddressBook(string name, List<Address> addresses)
        {
            Name = name;
            Addresses = addresses.ToList();
        }

        public IReadOnlyList<Address> Addresses { get; set; }

        public string Name { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            foreach (var address in Addresses)
            {
                yield return address;
            }
        }
    }
}