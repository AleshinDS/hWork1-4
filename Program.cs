using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;


namespace Ex4_1
{
    class MyArray
    {
        //Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
        //значения от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать
        //программу, позволяющую найти и вывести количество пар элементов массива, в которых только
        //одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
        //элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.


        private int[] arr;
        public MyArray(int[] arr)
        {
            this.arr = arr;
        }    
          
        public MyArray(int count)
        {
            Random random = new Random();
            arr = new int[count];
            for (int i =0; i < count; i++)
            {
                arr[i] = random.Next(-10000, 10000);
            }
        }
        
        public void Show()
        {
            for (int i =0; i<arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
        }

    static void Main(string[] args)
        {
            // MyArray arr = new MyArray(20);
            //arr.Show();
            // int count = 0;

            // for (int a = 0; a < 20; a++)
            // {
            //     if (arr[a] % 3 == 0 | arr[a+1] %3 == 0)  // возникает оишбка SC0021 "Не удается применить индексирование через [] к выражению типа MyArray"
            //     {
            //         count++;
            //         Console.WriteLine ($"пара {arr[a]} и {arr[a+1]} соответствует условиям")
            //     }
            // }
            // Console.WriteLine($"Количество пар, соответствующих условиям {count}");

            int[] array = new int[20]; // из-за ошибки тем методом сделать не смог, но примитивно по условию будет как то так. 
            Random rand = new Random();
            int count =0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10000, 10000);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
                Console.WriteLine();
            }
            for (int i = 0; i < array.Length -1; i++)
             {
                 if (array[i] % 3 == 0 | array[i+1] %3 == 0)  
                 {
                     count++;
                    Console.WriteLine($"пара {array[i]} и {array[i + 1]} соответствует условиям");
                 }
             }
             Console.WriteLine($"Количество пар, соответствующих условиям {count}");


        }

    }
    }


