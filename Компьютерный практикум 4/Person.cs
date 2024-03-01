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
        /// Создание поля имени
        /// </summary>
        private string name;
        /// <summary>
        /// Создание поля фамилии 
        /// </summary>
        private string surname;
        /// <summary>
        /// Создание поля дата рождения
        /// </summary>
        private DateTime birth;
        /// <summary>
        /// Создание поля факультет
        /// </summary>
        private string faculty;

        /// <summary>
        /// Свойство поля name
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        /// <summary>
        /// Свойство поля surname
        /// </summary>
        public string Surname { get { return surname; } set { surname = value; } }
        /// <summary>
        /// Свойство поля birth
        /// </summary>
        public DateTime Birth { get { return birth; } set { birth = value; } }
        /// <summary>
        /// Свойство поля faculty
        /// </summary>
        public string Faculty { get { return faculty; } set { faculty = value; } }
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
            this.name = name;
            this.surname = surname;
            this.birth = birth;
            this.faculty = faculty;
        }
        /// <summary>
        /// абстрактный метод, предназначенный для получения возраста персоны
        /// </summary>
        /// <returns></returns>
        public abstract int Age();
        /// <summary>
        /// виртуальный метод, который выводит информацию о персоне 
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine($"имя: {name}\nФамилия: {surname}\nДата рождения: {birth}\nФакультет: {faculty}");
        }
    }
}
