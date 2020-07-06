using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Commands;
using Store.Domain.Commands.CustomerCommands.Input;
using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.ValueObjects;

namespace Store.Tests
{
    [TestClass]
    public class CreateCustomerCommands
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

        }

        
    }
}
