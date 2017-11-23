using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ClassesEnterense
{
    class Program
    {
        static void Main(string[] args)
        {
            // название_класса (или интерфейса или предка) имя_переменной = new Конструктор(аргументы)
            User user = new User();
            //user.SetId(5);

            //Class1 class1 = new Class1();
            Console.WriteLine("Введите число");
            string text = Console.ReadLine();

            int number;
            bool isParsed = int.TryParse(text, out number);

            if(!isParsed)
            {
                Console.WriteLine("Ошибка");
                return;
            }

            Console.ReadLine();

            string str = "";
            int num = user.ToDo(ref str);
        }
    }
}
