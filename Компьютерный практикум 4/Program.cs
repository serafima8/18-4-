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
            while (true)
            {
                Console.Write("Введите персону: ");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "абитуриент":
                        Enrollee enrollee = new Enrollee();
                        persons.Add(Enrollee.Show());
                        foreach (var elem in persons)
                        {
                            elem.Print();
                            Console.WriteLine($"Возраст: {elem.Age()}");
                        }
                        break;
                    case "преподаватель":
                        Teacher teacher = new Teacher();
                        persons.Add(Teacher.Show());
                        foreach (var elem in persons)
                        {
                            elem.Print();
                            Console.WriteLine($"Возраст: {elem.Age()}");
                        }
                        break;
                    case "студент":
                        Student student = new Student();
                        persons.Add(Student.Show());
                        foreach (var elem in persons)
                        {
                            elem.Print();
                            Console.WriteLine($"Возраст: {elem.Age()}");
                        }
                        break;
                    case "0": return;
                    default:
                        Console.WriteLine("Персоны не существует");
                        break;
                }
                foreach (var elem in persons)
                {
                    if (elem.Age() > 20 && elem.Age() < 30)
                    {
                        Console.WriteLine($"Персона попадает в заданный диапазон ");
                    }
                    else
                    {
                        Console.WriteLine($"Персона не попадает в заданный диапазон ");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
