using System;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Ex4_4
{
    //Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
    //Создайте структуру Account, содержащую Login и Password.

    class Program
    {

        public static string[] LoadArrayFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamReader streamReader = new StreamReader(fileName);
                string[] arr = new string[10];
                int count = 0;
                while (!streamReader.EndOfStream)
                {
                    string a = streamReader.ReadLine();
                    arr[count] = a;
                    count++;
                }
                string[] buf = new string[count];
                Array.Copy(arr, buf, count);
                return buf;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        struct Account
        {
            public string Login;
            public string Password;
        }
            
               
        static void Main(string[] args)
        {
            string[] arr = LoadArrayFromFile(AppDomain.CurrentDomain.BaseDirectory + "TextFile1.txt");

            Account one;
            one.Login = arr[0];
            one.Password = arr[1];
            string Log, Pass;
            int count;
            count = 3;
            

            while (count > 0)
            {
                Console.Write("Введите логин: ");
                Log = Console.ReadLine();
                Console.Write("Введите пароль: ");
                Pass = Console.ReadLine();
                if (Log == one.Login && Pass == one.Password)
                {
                    Console.WriteLine("Добро пожаловать на GeekBrains.ru!");
                    return;
                }
                else
                {
                    count = count - 1;
                    Console.WriteLine($"Неверная пара логин/пароль, попробуйте снова. Попыток осталось: {count}");
                }
            }
            Console.WriteLine("Лимит попыток исчерпан. Доступ блокирован");
        }
         

        }
    }

