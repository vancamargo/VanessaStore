using Store.Domain.StoreContext.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Tests.FakeCustomerRepository
{
    public class FakeEmailService : IEmailService
    {
        public void Send(string to, string from, string subject, string body)
        {
           
        }
    }
}
