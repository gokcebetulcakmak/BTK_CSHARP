using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add() //virtual inheritance yaptığımız kodda değişiklik yapmak istediğimizde (kodu ezmek)
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer : Database
    {
        public override void Add() //virtual olarak belirtilen sınıfın gövdesini değiştirmek istediğimizde override kullanırız.
        {
            Console.WriteLine("Added by Sql Code");
            // base.Add(); //override edilmiş bir metot içerisinden metodun orijinalini (temel sınıf içerisindeki halini) çağırabilmek için base anahtar sözcüğü kullanılır.
        }

    }
    class MySql : Database
    {

    }
}
