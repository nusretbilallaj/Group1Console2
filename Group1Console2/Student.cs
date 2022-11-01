using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1Console2
{
    internal class Student:Person
    {
        public Student(string emri,string mbiemri, string adresa):base(emri,mbiemri)
        {
            Adresa = adresa;
        }

        public string Adresa { get; set; }

        public override void SayHello()
        {
            Console.WriteLine($"Tungjatjeta student {Emri} {Mbiemri} nga {Adresa}");
        }

    }
}
