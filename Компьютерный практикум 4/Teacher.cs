using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_4
{
    class Teacher : Person
    {
        /// <summary>
        /// Создание поля должность
        /// </summary>
        private string post;
        /// <summary>
        /// Создание поля стажа
        /// </summary>
        private int experience;
        /// <summary>
        /// Свойство поля post
        /// </summary>
        public string Post { get; set; }
        /// <summary>
        /// Свойство поля experience
        /// </summary>
        public int Experience { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Teacher() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="birth">Дата рождения</param>
        /// <param name="faculty">Факультет</param>
        /// <param name="post">Должность</param>
        /// <param name="experience">Стаж работы</param>
        public Teacher(string name, string surname, DateTime birth, string faculty,string post, int experience) : base(name, surname, birth, faculty)
        {
            this.Post = post;
            this.Experience = experience;
        }
        /// <summary>
        /// Метод, который выводит информацию о преподавателе
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Имя: {Name}\nФамилия: {Surname}\nДата рождения: {Birth}\nФакультет: {Faculty}\n Должность: {post}\nСтаж: {experience}\nВозраст: {Age()}");
        }
        /// <summary>
        /// Метод, с помощью которого мы вводим информацию о препо
        /// </summary>
        /// <returns></returns>
        static public Teacher Show()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            DateTime birth = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Введите факультет: ");
            string faculty = Console.ReadLine();
            Console.Write("Введите должность: ");
            string post = Console.ReadLine();
            Console.Write("Введите стаж работы: ");
            int experience = int.Parse(Console.ReadLine());
            return new Teacher(name, surname, birth, faculty,post,experience);
        }
    }
}
