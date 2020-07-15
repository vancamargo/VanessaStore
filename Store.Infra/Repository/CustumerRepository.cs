using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.Repositories;
using Store.Infra.StoreContext.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Dapper;
using System.Data;
using Store.Domain.StoreContext.ValueObjects;
using Store.Domain.Queries;

namespace Store.Infra.Repository
{
    public class CustumerRepository : ICustomerRepository
    {
        private readonly VanessaDataContext _context;

        public CustumerRepository(VanessaDataContext context)
        {
            _context = context;
        }
        public bool CheckEmail(string email)
        {
            return
               _context
               .Connection
               .Query<bool>(
                   "spCheckEmail",
                   new { Email = email },
                   commandType: CommandType.StoredProcedure)
               .FirstOrDefault();
        }

        public bool ChekDocument(string document)
        {
            return
              _context
              .Connection
              .Query<bool>(
                  "spCheckDocument",
                  new { Document = document },
                  commandType: CommandType.StoredProcedure)
              .FirstOrDefault();
        }

        public CustomerOrderCountResult GetCustomerOrderCount(string document)
        {
            return
              _context
              .Connection
              .Query<CustomerOrderCountResult>(
                  "spGetCustomerOrderCount",
                  new { Document = document },
                  commandType: CommandType.StoredProcedure)
              .FirstOrDefault();
        }

        public void Save(Customer customer)
        {
            _context.Connection.Execute("spCreateCustomer",
            new
            {
                Id = customer.Id,
                FirstName = customer.Name.FirstName,
                LastName = customer.Name.LastName,
                Document = customer.Document.Number,
                Email = customer.Email.Adress,
                Phone = customer.Phone
            }, commandType: CommandType.StoredProcedure);

            foreach (var address in customer.Adresses)
            {
                _context.Connection.Execute("spCreateAddress",
                new
                {
                    Id = address.Id,
                    CustomerId = customer.Id,
                    Number = address.Number,
                    Complement = address.Complement,
                    District = address.Disctrict,
                    City = address.City,
                    State = address.State,
                    Country = address.Country,
                    ZipCode = address.ZipCode,
                    Type = address.Type,
                }, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
