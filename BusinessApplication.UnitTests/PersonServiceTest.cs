using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication.Core;
using Moq;

namespace BusinessApplication.UnitTests
{
    [TestFixture]
    public class PersonServiceTest
    {
        [Test]
        public void ShouldBeAbleToGetPersonServiceAndGetPerson()
        {
            var expected = new Person { Id = 1, FirstName = "John", LastName = "Doe" };
            var personRepositoryMock = new Mock<IPersonRespository>();
            personRepositoryMock
                .Setup(pr => pr.GetPerson(1))
                .Returns(new Person { Id = 1, FirstName = "Bob", LastName = "Smith" });
            var personService = new PersonService(personRepositoryMock.Object);
            var actual = personService.GetPerson(expected.Id);
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
