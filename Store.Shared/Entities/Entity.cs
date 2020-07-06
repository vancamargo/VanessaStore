using FluentValidator;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Store.Shared.Entities
{
    public class Entity: Notifiable 
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
