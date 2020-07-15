using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Store.Domain.Queries
{
    public class CustomerOrderCountResult
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }

        public string Document { get; set; }
        public int Orders { get; set; }
    }
}
