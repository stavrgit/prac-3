using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part_1();
           //Part_2();
            //Part_3();
        }


        static void Part_1()
        {
            
            ArrayList arrayList = new ArrayList();

            //a) Заполните ее 5-ю случайными целыми числами
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                arrayList.Add(random.Next(1, 101)); // Случайные числа от 1 до 100
            }

            //b) Добавьте к ней строку
            arrayList.Add("Hello, ArrayList!");

            //c) Удалите заданный элемент
            Console.Write("Введите число для удаления из коллекции: ");
            if (int.TryParse(Console.ReadLine(), out int numberToRemove))
            {
                if (arrayList.Contains(numberToRemove))
                {
                    arrayList.Remove(numberToRemove);
                    Console.WriteLine($"Число {numberToRemove} удалено из коллекции.");
                }
                else
                {
                    Console.WriteLine($"Число {numberToRemove} не найдено в коллекции.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }

            //d) Удалите заданный элемент   
            Console.WriteLine($"Количество элементов в коллекции: {arrayList.Count}");
            Console.WriteLine("Элементы коллекции:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //e) Выполните поиск в коллекции заданного значения
            Console.Write("Введите число для поиска в коллекции: ");
            if (int.TryParse(Console.ReadLine(), out int numberToSearch))
            {
                if (arrayList.Contains(numberToSearch))
                {
                    Console.WriteLine($"Число {numberToSearch} найдено в коллекции.");
                }
                else
                {
                    Console.WriteLine($"Число {numberToSearch} не найдено в коллекции.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }


        static void Part_2()
        {
            
            Queue<int> First_Collection = new Queue<int>();
            for (int i = 1; i <= 10; i++)
            {
                First_Collection.Enqueue(i); 
            }

            //a) Выведите коллекцию на консоль
            PrintQueue(First_Collection);

            //b) Удалите из коллекции n элементов 
            First_Collection.Dequeue();
            Console.WriteLine("\nПосле удаления.");
            PrintQueue(First_Collection);

            //c) Добавьте другие элементы (используйте все возможные методы добавления для вашей коллекции)
            First_Collection.Enqueue(11); 
            Console.WriteLine("\nПосле добавления новых элементов:");
            PrintQueue(First_Collection);


            //d) Создайте вторую коллекцию
            List<int> Second_Collection = new List<int>(First_Collection);

            //e) Выведите вторую коллекцию на консоль
            Console.WriteLine("\nВторая коллекция (List<int>):");
            PrintList(Second_Collection);

            //f) Найдите во второй коллекции заданное значение
            Console.Write("\nВведите значение для поиска во второй коллекции: ");
            if (int.TryParse(Console.ReadLine(), out int valueToFind))
            {
                if (Second_Collection.Contains(valueToFind))
                {
                    Console.WriteLine($"Значение {valueToFind} найдено во второй коллекции.");
                }
                else
                {
                    Console.WriteLine($"Значение {valueToFind} не найдено во второй коллекции.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }

        static void PrintQueue(Queue<int> queue)
        {
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        





        static void Part_3()
        {
            Queue<Laptop> laptop = new Queue<Laptop>();
       
            new Laptop("XPS 13", "Dell", 1200);
            new Laptop("MacBook Air", "Apple", 1000);

            


        }
    }
}
