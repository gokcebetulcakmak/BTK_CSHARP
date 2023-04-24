using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList();

            //List();

            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");
            //Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);//.key
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));//Keylerde glass var mı? False
            Console.WriteLine(dictionary.ContainsValue("tablo"));//Value de tablo var mı? True




            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();//Tip Güvenli Koleksiyonlar
            cities.Add("Ankara");
            cities.Add("Edirne");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("**********");


            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer {Id=1, FirstName="Gökçe"});
            //customers.Add(new Customer {Id=2, FirstName="Betül"});

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Gökçe" },
                new Customer { Id = 2, FirstName = "Betül" }

            };

            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Ayşe"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2] //Veri tabanına yeni bir liste eklenmek istendiğinde kullanılabilir.
            {
                new Customer{Id=4, FirstName="Büşra"},
                new Customer{Id=5,FirstName="Damla"}
            });
            //customers.Clear();//Listeyi temizler.

            Console.WriteLine(customers.Contains(customer2));//Contains=>

            var index = customers.IndexOf(customer2);//Kaçıncı sırada olduğunu belirler
            Console.WriteLine("Index:{0}", index);
            //LastIndexOf aramaya sondan başlar.

            customers.Insert(0, customer2);//0.cı indekse ekler.listeyi kaydırır. kaçıncı indekse ekleyeceğimizi belirleyebiliriz.
                                           // customers.Remove(customer2 );//customer2 yi siler

            customers.RemoveAll(c => c.FirstName == "Betül");//customers da ismi Betül olanı siler.


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count();
            Console.WriteLine("Count:{0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();//Çalştığımz nesnede özellikle veri tipi yoksa (tip güvenli çalışma yoksa) Array List kullanılabilir.Fakat projelerde genellikle Type Safety çalışılır.
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("A");
            cities.Add(1);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
