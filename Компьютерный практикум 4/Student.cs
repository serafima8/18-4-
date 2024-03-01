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
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="birth"></param>
        /// <param name="faculty"></param>
        /// <param name="course"></param>
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
                Console.WriteLine($"Возраст: {DateTime.Now.Year - Birth.Year - 1}");
            }
            else
            {
                Console.WriteLine($"Возраст: {DateTime.Now.Year - Birth.Year}");
            }
            return Age();
        }
        /// <summary>
        /// Метод, который выводит информацию о студенте 
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Курс: {course}");
        }


    }
}
