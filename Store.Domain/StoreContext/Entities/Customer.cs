using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.StoreContext.Entities
{

    public class Customer
    {
        public Customer(
            string firstName, 
            string lastName, 
            string document, 
            string email, 
            string phone, 
            string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            Phone = phone;
            Address = address;

        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
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
        
    


        
      


