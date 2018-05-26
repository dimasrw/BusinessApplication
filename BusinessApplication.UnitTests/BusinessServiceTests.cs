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
    }
}
