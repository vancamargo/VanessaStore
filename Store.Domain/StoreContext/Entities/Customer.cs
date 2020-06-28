using Store.Domain.StoreContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Domain.StoreContext.Entities
{

    public class Customer
    {
        private readonly IList<Address> _addresses;
        public Customer(
            Name  name, 
            Document document, 
            Email email, 
            string phone)
        {
            Name = name;
            Document = document;
            Email = email;
            Phone = phone;
            _addresses = new List<Address>();

        }

        public Name Name { get; set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Adresses => _addresses.ToArray();

        public void AddAdress(Address address)
        {
            _addresses.Add(address);
        }

        public override string ToString()
        {
            return Name.ToString();
        }


    }
    //public interface IPerson
    //{
    //     string Name { get; set; }
    //     DateTime BirthDate { get; set; }

    //}

    //public interface IEmployee
    //{
       
    //    decimal Salary { get; set; }
    //}
    //public abstract class Person
    //{
    //    public string Name { get; set; }
    //    public DateTime BirthDate { get; set; }
    //    public decimal Salary { get; set; }
    //}
    ////Propriedades 
    //public class Customers:IPerson, IEmployee
    //{
    //    public string Name { get; set; }
    //    public DateTime BirthDate { get; set; }
    //    public decimal Salary { get; set; }

    //    //Metodos

    //    public void Register() { }

    //    //Eventos
    //    public void AoRegistrar() { }

    //    public override string ToString(){
    //        return Name;
    //     }
    //}
   
    
    //public class SalesMan :Person
    //{
       
     
    //}
}
        
    


        
      


