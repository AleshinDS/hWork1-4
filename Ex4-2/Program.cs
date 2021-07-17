using System;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Ex4_2
{
    //Реализуйте задачу 1 в виде статического класса StaticClass;
    //а) Класс должен содержать статический метод, который принимает на вход массив и решает
    //задачу 1;
    //б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен
    //возвращать массив целых чисел;
    //в)** Добавьте обработку ситуации отсутствия файла на диске.
    class Program
    {
        public static class InputArray
        {
            public static int[] LoadArrayFromFile(string fileName)
            {
                if (File.Exists(fileName))
                {
                    StreamReader streamReader = new StreamReader(fileName);
                    int[] arr = new int[20];
                    int count = 0;
                    while (!streamReader.EndOfStream)
                    {
                        int a = int.Parse(streamReader.ReadLine());
                        arr[count] = a;
                        count++;
                    }
                    return arr[];
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            public static void Show()
            {
                string[] arr = int.Parse(LoadArrayFromFile(AppDomain.CurrentDomain.BaseDirectory + "Array42.txt"));
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]}\t");
                }
            }


        }

        static void Main(string[] args)
        {
           


            }
        }

        
        }
    


