using FluentAssertions;
using NUnit.Framework;
using ProductiveDDD.Tests.Mocks;

namespace ProductiveDDD.Tests
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "snake case for test methods")]
    public class ValueObjectTests
    {
        [Test]
        public void different_addressbooks_are_not_equals()
        {
            var book1 = ValueObjectFactory.HighwayToHellAddress();
            var book2 = ValueObjectFactory.StairwayToHeaven();

            book1.Should().NotBe(book2);
            book2.Should().NotBe(book1);
        }

        [Test]
        public void different_addressbooks_are_not_equals_with_operator()
        {
            var book1 = ValueObjectFactory.HighwayToHellAddress();
            var book2 = ValueObjectFactory.StairwayToHeaven();

            var result = book1 != book2;
            result.Should().BeTrue();
        }

        [Test]
        public void different_addresses_are_not_equals()
        {
            var add1 = ValueObjectFactory.HighwayToHellAddress();
            var add2 = ValueObjectFactory.StairwayToHeaven();

            add1.Should().NotBe(add2);
            add2.Should().NotBe(add1);
        }

        [Test]
        public void different_addresses_are_not_equals_with_operator()
        {
            var add1 = ValueObjectFactory.HighwayToHellAddress();
            var add2 = ValueObjectFactory.StairwayToHeaven();

            var result = add1 != add2;
            result.Should().BeTrue();
        }

        [Test]
        public void same_addressbooks_are_equals()
        {
            var book1 = ValueObjectFactory.HeavenAddressBook();
            var book2 = ValueObjectFactory.HeavenAddressBook();

            book1.Should().Be(book2);
            book2.Should().Be(book1);
        }

        [Test]
        public void same_addressbooks_are_equals_with_operator()
        {
            var book1 = ValueObjectFactory.HighwayToHellAddress();
            var book2 = ValueObjectFactory.HighwayToHellAddress();

            var result = book1 == book2;
            result.Should().BeTrue();
        }

        [Test]
        public void same_addresses_are_equals()
        {
            var add1 = ValueObjectFactory.HighwayToHellAddress();
            var add2 = ValueObjectFactory.HighwayToHellAddress();

            add1.Should().Be(add2);
            add2.Should().Be(add1);
        }

        [Test]
        public void same_addresses_are_equals_with_operator()
        {
            var add1 = ValueObjectFactory.HighwayToHellAddress();
            var add2 = ValueObjectFactory.HighwayToHellAddress();

            var result = add1 == add2;
            result.Should().BeTrue();
        }
    }
}