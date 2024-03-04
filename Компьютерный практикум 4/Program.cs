using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            //Создание базы
            while (true)
            {
                Console.Write("Введите персону: ");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "абитуриент":
                        Enrollee enrollee = new Enrollee();
                        persons.Add(Enrollee.Show());
                        break;
                    case "преподаватель":
                        Teacher teacher = new Teacher();
                        persons.Add(Teacher.Show());
                        break;
                    case "студент":
                        Student student = new Student();
                        persons.Add(Student.Show());
                        break;
                       
                    case "0": return;
                    default:
                        Console.WriteLine("Персоны не существует");
                        break;
                }
                foreach (var elem in persons)
                {
                    elem.Print();
                }
                Console.WriteLine();
                Console.Write("Введите нижнюю границу: ");
                int minAge = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите верхнюю границу: ");
                int maxAge = Convert.ToInt32(Console.ReadLine());
                for(int i=0;i<persons.Count;i++)
                {
                    if (persons[i].Age() > minAge && persons[i].Age() < maxAge) 
                    {
                        persons[i].Print();
                    }
                }

                Console.ReadKey();
            }
        }
    }
}
