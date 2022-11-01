using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1Console2
{
    internal class Profesor:Person
    {
        public Profesor(string emri, string mbiemri):base(emri, mbiemri)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine($"Tungjatjeta profesor {Emri} {Mbiemri}");
        }
    }
}
