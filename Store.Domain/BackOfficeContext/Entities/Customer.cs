using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.BackOfficeContext
{
    public class Customer
    {
        public IReadOnlyCollection<Product> Products { get; set; }
        public Name Name { get; set; }
    }
}
