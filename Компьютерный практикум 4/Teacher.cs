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

        public string Post { get { return post; } set { post = value; } }
        public int Experience { get { return experience; } set { experience = value; } }

        public Teacher() { }

        public Teacher(string name, string surname, DateTime birth, string faculty,string post, int experience) : base(name, surname, birth, faculty)
        {
            this.post = post;
            this.experience = experience;
        }
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

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Должность: {post}\nСтаж: {experience}");
        }
    }
}
