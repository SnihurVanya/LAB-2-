using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Task1()
        {
            //Створити укземпляр класу Address.
            Address nt = new Address();

            //У поля екземпляра записати інформаію про поштову адресу.
            nt.Index = 07442;
            nt.Country = "Ukraine";
            nt.City = "Kyiv";
            nt.Street = "Stepana Razina";
            nt.House = "6";
            nt.Apartment = "7";

            //Виведіть на екран значення полів, що описують адресу.
            Console.Out.WriteLine("Index; " + nt.Index);
            Console.Out.WriteLine("Cointry: " + nt.Country);

            //Створити екземпляр класу Address.
            Address nt = new Address();

            //У поля екземпляра записати інформацію про поштову адресу.
            nt.Index = 07442;
            nt.Country = "Ukraine";
            nt.City = "Kyiv";
            nt.Street = "Stepana Razina";
            nt.House = "6";
            nt.Apartment = "7";

            //Виведіть на екран значення полів, що описують адресу.
            Console.Out.WriteLine("Index: " + nt.Index);
            Console.Out.WriteLine("Country: " + nt.Country);
            Console.Out.WriteLine("City: " + nt.City);
            Console.Out.WriteLine("Street: " + nt.Street);
            Console.Out.WriteLine("House: " + nt.House);
            Console.Out.WriteLine("Apartment: " + nt.Apartment);






        }
        static void Task2()
        {
            //Створити екземпляр класу Converter.
            Converter conv = new Converter(36.96, 38.79, 8.37);
            Console.WriteLine("What do you want to do?);
    
                string user_selection = Console.ReadLine();
            int selection = Convert.ToInt16(user_selection);

            
            
                
            
        }
        static void Task4()
        {
            //Створити клас User
            User user = new User("User", "Ivan", "Snihur", 18);
            //Реалізуйте виведення на екран інформаії про користувача.
            user.Output();
        }
          
    }
}
