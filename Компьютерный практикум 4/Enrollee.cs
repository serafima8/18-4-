using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_4
{
    class Enrollee : Person
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Enrollee() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="birth">Дата рождения</param>
        /// <param name="faculty">Факультет</param>
        public Enrollee(string name, string surname, DateTime birth, string faculty) : base(name, surname, birth, faculty)
        { }
        
        /// <summary>
        /// метод, который выводит информацию об абитуриенте
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Имя: {Name}\nФамилия: {Surname}\nДата рождения: {Birth.ToShortDateString()}\nФакультет: {Faculty}\nВозраст: {Age()}");
        }
        /// <summary>
        /// Метод, с помощью которого мы вводим информацию об абитуриенте 
        /// </summary>
        /// <returns></returns>
        public static Enrollee Show()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            DateTime birth = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Введите факультет: ");
            string faculty = Console.ReadLine();
            return new Enrollee(name, surname, birth, faculty);
        }
    }
}
