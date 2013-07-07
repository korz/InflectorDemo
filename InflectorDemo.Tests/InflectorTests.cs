using NUnit.Framework;

namespace InflectorDemo.Tests
{
    public class InflectorTests
    {
        #region ToSingular
        [Test]
        public void ToSingular_Test_Addresses()
        {
            const string plural = "Addresses";

            var result = plural.ToSingular();

            Assert.AreEqual("Address", result);
        }

        [Test]
        public void ToSingular_Test_Wolves()
        {
            const string plural = "Wolves";

            var result = plural.ToSingular();

            Assert.AreEqual("Wolf", result);
        }

        [Test]
        public void ToSingular_Test_Cars()
        {
            const string plural = "Cars";

            var result = plural.ToSingular();

            Assert.AreEqual("Car", result);
        }
        #endregion

        #region ToPlural
        [Test]
        public void ToPlural_Test_Address()
        {
            const string plural = "Address";

            var result = plural.ToPlural();

            Assert.AreEqual("Addresses", result);
        }

        [Test]
        public void ToPlural_Test_Wolf()
        {
            const string plural = "Wolf";

            var result = plural.ToPlural();

            Assert.AreEqual("Wolves", result);
        }

        [Test]
        public void ToPlural_Test_Car()
        {
            const string plural = "Car";

            var result = plural.ToPlural();

            Assert.AreEqual("Cars", result);
        }
        #endregion

        #region ToCamelCase
        [Test]
        public void ToCamelCase_Test_Address()
        {
            const string plural = "Address";

            var result = plural.ToCamelCase();

            Assert.AreEqual("address", result);
        }

        [Test]
        public void ToCamelCase_Test_CustomerContact()
        {
            const string plural = "CustomerContact";

            var result = plural.ToCamelCase();

            Assert.AreEqual("customerContact", result);
        }

        [Test]
        public void ToCamelCase_Test_Customercontact()
        {
            const string plural = "Customercontact";

            var result = plural.ToCamelCase();

            Assert.AreEqual("customercontact", result);
        }

        [Test]
        public void ToCamelCase_Test_customerContact()
        {
            const string plural = "customerContact";

            var result = plural.ToCamelCase();

            Assert.AreEqual("customerContact", result);
        }
        #endregion
    }
}
