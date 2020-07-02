using Store.Domain.BackOfficeContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Commands.OrderCommands.Inputs
{
    public class PlaceOrderCommand
    {
        public Guid Customer  { get; set; }
    }
}
