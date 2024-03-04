using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум_4
{
    abstract class Person
    {
        /// <summary>
        /// Свойство поля name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Свойство поля surname
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Свойство поля birth
        /// </summary>
        public DateTime Birth { get; set; }
        /// <summary>
        /// Свойство поля faculty
        /// </summary>
        public string Faculty { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Person() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="birth"></param>
        /// <param name="faculty"></param>
        public Person(string name, string surname, DateTime birth,string faculty)
        {
            this.Name = name;
            this.Surname = surname;
            this.Birth = birth;
            this.Faculty = faculty;
        }
        /// <summary>
        /// абстрактный метод, предназначенный для получения возраста персоны
        /// </summary>
        /// <returns></returns>
        //public abstract int Age();

        public int Age()
        {
            return DateTime.Now.Year - Birth. Year;
        }
        /// <summary>
        /// виртуальный метод, который выводит информацию о персоне 
        /// </summary>
        public abstract void Print();
        //{
        //    Console.WriteLine($"имя: {Name}\nФамилия: {Surname}\nДата рождения: {Birth}\nФакультет: {Faculty}");
        //}

       
    }
    
}
