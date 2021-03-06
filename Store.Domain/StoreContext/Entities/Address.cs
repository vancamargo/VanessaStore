﻿
using FluentValidator;
using Store.Domain.StoreContext.Enums;
using Store.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.StoreContext.Entities
{
    public class Address:  Entity
    {
        public Address(string street,
            string number,
            string complement,
            string disctrict,
            string city,
            string state,
            string country,
            string zipCode,
            EAdressType type)
        {
            Street = street;
            Number = number;
            Complement = complement;
            Disctrict = disctrict;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
            Type = type;
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string Disctrict { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public EAdressType Type { get; private set; }

        public override string ToString()
        {
            return $"{Street}, {Number} - {City}/{State}";
        }
    }
}
