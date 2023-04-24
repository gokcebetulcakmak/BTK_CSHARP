using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[4];
            students[0] = "Gokce";
            students[1] = "Busra";
            students[2] = "Ayse";
            students[3] = "Damla";

            string[] students2 = { "Gokce", "Damla", "Ayse", "Busra" };//Dizinin diğer bir tanımlama şekli


            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.WriteLine("****************");
            //foreach (var student2 in students2)
            //{
            //    Console.WriteLine(student2);
            //}


            //Çok Boyutlu Diziler


            string[,] regions = new string[5, 3] //5 bölge 3 şehir
            {
             {"İstanbul","Kocaeli","Balıkesir"},
             {"Ankara","Konya","Kırıkkale"},
             {"Antalya","Adana","Mersin"},
             {"Trabzon","Rize","Artvin"},
             {"İzmir","Muğla","Aydın"},

            };
            for (int i = 0; i<=regions.GetUpperBound(0); i++) 
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("***********");
            }


            Console.ReadLine();
        }
    }
}
