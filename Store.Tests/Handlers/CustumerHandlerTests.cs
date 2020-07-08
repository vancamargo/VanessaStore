using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Commands.CustomerCommands.Input;
using Store.Domain.StoreContext.Handlers;
using Store.Tests.FakeCustomerRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Tests.Handlers
{
    [TestClass]
    public class CustumerHandlerTests
    {

        [TestMethod]
        public void ShouldValidateWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "Vanessa";
            command.LastName = "Camargo";
            command.Document = "28659170377";
            command.Email = "vancamargo@gmail.com";
            command.Phone = "119999999999";

            Assert.AreEqual(true, command.Valid());
            var handler = new CustomerHandler(new CustomerRepositoryFake(), new FakeEmailService());

        }
    }
}
