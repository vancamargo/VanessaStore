using System;
using System.Collections.Generic;
using System.Text;

namespace BaltaStore.Domain.StoreContext
{
    public interface IPerson
    {
         string Name { get; set; }
         DateTime BirthDate { get; set; }

    }

    public interface IEmployee
    {
       
        decimal Salary { get; set; }
    }
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
    }
    //Propriedades 
    public class Customers:IPerson, IEmployee
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        //Metodos

        public void Register() { }

        //Eventos
        public void AoRegistrar() { }
    }
   

    public class SalesMan :Person
    {
       
     
    }
}
        
    


        
      


