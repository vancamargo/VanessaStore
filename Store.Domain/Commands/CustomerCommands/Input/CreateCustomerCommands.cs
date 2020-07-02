using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Commands.CustomerCommands.Input
{
    public class CreateCustomerCommands
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
