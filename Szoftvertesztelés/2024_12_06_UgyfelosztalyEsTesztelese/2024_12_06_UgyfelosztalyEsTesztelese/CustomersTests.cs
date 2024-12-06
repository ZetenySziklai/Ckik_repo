using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Legacy;

namespace _2024_12_06_UgyfelosztalyEsTesztelese
{
    [TestFixture]
    internal class CustomersTests
    {
        List<Customer> customers;
        [SetUp]
        public void SetUp()
        {
            customers = new List<Customer>{
                new Customer("John", "Doe", "JohnDoe@gmail.com", new DateTime(1990, 5, 15)),
                new Customer("Jane", "Smith", "jane.smith@example.com",new DateTime(1985, 8, 22)),
                new Customer("Alice", "Johnson", "alice.johnson@example.com", new DateTime(1992, 11, 3)),
                new Customer("Bob", "Brown", "bob.brown@example.com", new DateTime(1980, 2, 10)),
                new Customer("Charlie", "Davis", "charlie.davis@example.com", new DateTime(1995, 7, 25)),
                new Customer("Emily", "Miller", "emily.miller@example.com", new DateTime(1988, 12, 12))
            };
        }
        [TestCase(34, 0)]
        [TestCase(39, 1)]
        [TestCase(32, 2)]
        [TestCase(44, 3)]
        [TestCase(29, 4)]
        [TestCase(35, 5)]
        public void GetAge_ReturnsCorrectAges(int expectAge, int index)
        {
            int age = customers[index].GetAge();
            ClassicAssert.AreEqual(expectAge,age);

        }
    }
}
