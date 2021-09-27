using Reflection.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reflection.Container;
using Reflection.Services;

namespace Reflection.Test
{
    [TestClass]
    public class MyContainerTests
    {
        [TestMethod]
        public void CanResolveTypesWithoutDefaultCtor()
        {
            var container = new MyContainer();
            container.For<ILogger>().Use<SqlServerLogger>();
            container.For<IRepository<Employee>>().Use<SqlRepository<Employee>>();

            var repository = container.Resolve<IRepository<Employee>>();

            Assert.AreEqual(typeof(SqlRepository<Employee>), repository.GetType());
        }

        [TestMethod]
        public void CanResolveConcreteType()
        {
            var container = new MyContainer();
            container.For<ILogger>().Use<SqlServerLogger>();
            container.For(typeof(IRepository<>)).Use(typeof(SqlRepository<>));

            var service = container.Resolve<InvoiceService>();

            Assert.IsNotNull(service);
        }
    }
}