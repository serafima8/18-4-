using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_4
{
    class Enrollee : Person
    {

        public Enrollee(string name, string surname, DateTime birth, string faculty) : base(name, surname, birth, faculty) { }
        public override int Age()
        {
           
            if(DateTime.Now<(Birth.AddYears(DateTime.Now.Year-Birth.Year)))
            {
                Console.WriteLine($"Возраст: {DateTime.Now.Year - Birth.Year-1}");
            }
            else
            {
                Console.WriteLine($"Возраст: {DateTime.Now.Year-Birth.Year}");
            }
            return Age();
        }

        public override void Print()
        {
            base.Print();
        }
      
    }
}
