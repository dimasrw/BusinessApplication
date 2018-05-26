using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ninject;
using BusinessApplication.Core;

namespace BusinessApplication.UnitTests
{
    [TestFixture]
    public class BusinessServiceTests
    {
        [Test]
        public void ShouldBeAbleToGetBusinessServiceFromNinjet()
        {
            BusinessService actual;
            var kernel = new StandardKernel(new CoreModule());
            actual = kernel.Get<BusinessService>();
            Assert.IsNotNull(actual);
        }

        [Test]
        public void ShouldBeAbleToGetPersonServiceAndGetPerson()
        {
            var expected = new Person { Id = 1, FirstName = "John", LastName = "Doe" };
            var kernel = new StandardKernel(new CoreModule());
            var personService = kernel.Get<PersonService>();
            var actual = personService.GetPerson(expected.Id);
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
