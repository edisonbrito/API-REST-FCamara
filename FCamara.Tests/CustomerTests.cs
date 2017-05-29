using FCamara.Domain.Entities;
using FCamara.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FCamara.Tests
{
    [TestClass]
    public class CustomerTests
    {
        private readonly User user = new User("Edison", "Edison");
        private readonly Email email = new Email("edijs.britto@gmail.com");

        [TestMethod]
        [TestCategory("Customer - New Customer")]
        public void GivenAnInvalidFirstNameShouldReturnANotification()
        {
            var customer = new Customer("Edison Brito", email, user);

            Assert.IsFalse(!customer.IsValid());
        }
    }
}
