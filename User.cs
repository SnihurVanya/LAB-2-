using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class User
    {
        public string login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; }

        public User(string login, string name, string surname, int age)//логін, ім'я, прізвище, вік, дату заповненняанкети
        {
            login = login;
            Name = name;
            Surname = surname;
            Age = age;
            Date = System.DateTime.Now;
        }
        public void Output()
        {
            Console.WriteLine("Login: " + login);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Date:" + date);
        }
            

        
    }
}
