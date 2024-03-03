using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_4
{
    class Student : Person
    {
        /// <summary>
        /// Создание поля курс
        /// </summary>
        private int course;
        /// <summary>
        /// Свойство поля course
        /// </summary>
        public int Course { get { return course; } set { course = value; } }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Student() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="birth">Дата рождения</param>
        /// <param name="faculty">Факультет</param>
        /// <param name="course">Курс</param>
        public Student(string name, string surname, DateTime birth, string faculty,int course) : base(name, surname, birth, faculty)
        {
            this.course = course;
        }
        /// <summary>
        /// Метод, который выводит информацию о возрасте студента
        /// </summary>
        /// <returns></returns>
        public override int Age()
        {
            if (DateTime.Now < (Birth.AddYears(DateTime.Now.Year - Birth.Year)))
            {
                return DateTime.Now.Year - Birth.Year - 1;
            }
            else
            {
                return DateTime.Now.Year - Birth.Year;
            }
        }
        /// <summary>
        /// Метод, который выводит информацию о студенте 
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Курс: {course}");
        }
        /// <summary>
        /// етод, с помощью которого мы вводим информацию о студенте 
        /// </summary>
        /// <returns></returns>
        static public Student Show()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            DateTime birth = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Введите факультет: ");
            string faculty = Console.ReadLine();
            Console.Write("Введите курс: ");
            int course = int.Parse(Console.ReadLine());
            return new Student(name, surname, birth, faculty,course);
        }

    }
}
