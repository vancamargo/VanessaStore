using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.StoreContext.ValueObjects
{
    public class Email
    {
        public Email(string adress)
        {
            Adress = adress;
        }

        public string  Adress { get; private set; }

        public override string ToString()
        {
            return Adress;
        }
    }
}
