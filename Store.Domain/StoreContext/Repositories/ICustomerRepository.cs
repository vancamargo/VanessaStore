

using Store.Domain.Queries;
using Store.Domain.StoreContext.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.StoreContext.Repositories
{
    public interface ICustomerRepository
    {
        bool ChekDocument(string document);
        bool CheckEmail(string email);
        void Save(Customer customer);
        CustomerOrderCountResult GetCustomerOrderCount(string document);
    }
}
