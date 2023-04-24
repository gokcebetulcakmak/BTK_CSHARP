using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        //private int Id { get; set; } //Private sadece tanımlandığı sınıf içinde kullanılabilir
        protected int Id {  get; set; } //Inherit edildiği sınıflarda kullanılabilir.
        public void Save()
        {

        }
       
    }
    class Student:Customer
    {
        public void Save2()
        { 
           
        }
    }
    class Course //Classın Default u internaldır.Internal istenilen yerde çağrılabilir.Mevcut projede kullanılır.
    {
        public string Name { get; set; }
    }

    //public referans verildiği zaman başka projede kullanılabilir.
}
