using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();


        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer { Id = 1, FirstName = "Gökçe", Adress = "İstanbul", LastName = "Çakmak" };


            Student student = new Student
            {
                Id = 1,
                FirstName = "Ayşe",
                LastName = "Yurtseven",
                Departmant = "Data Science"
            };
            manager.Add(student);
            manager.Add(customer);
        }
    }

    interface IPerson
    {
       int Id { get; set; }
       string FirstName { get; set; }
       string LastName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set; }
        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }

    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }

    }

}
