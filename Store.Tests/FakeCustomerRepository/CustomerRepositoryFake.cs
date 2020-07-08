using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Tests.FakeCustomerRepository
{
    public class CustomerRepositoryFake : ICustomerRepository
    {
        public bool CheckEmail(string email)
        {
            return false;
        }

        public bool ChekDocument(string document)
        {
            return false;
        }

        public void Save(Customer customer)
        {
          
        }
    }
}
