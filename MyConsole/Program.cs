using MyLibrary;
using System;

namespace MyConsole
{
    class Program
    {
        static MyLinkedList<Product> lists = new MyLinkedList<Product>();

        static void Main(string[] args)
        {
            lists.Add(new Product { MyProperty = 6 });
            lists.Add(new Product { MyProperty = 7 });
            lists.Add(new Product { MyProperty = 8 });
            lists.Add(new Product { MyProperty = 9 });
            lists.Add(new Product { MyProperty = 10 });

            Console.WriteLine("Add");
            Show();

            Console.WriteLine("=============================");
            Console.WriteLine("Show 2 elements by index");
            Console.WriteLine(lists.GetElement(2).MyProperty);
            Console.WriteLine(lists.GetElement(3).MyProperty);
            Console.WriteLine("=============================");

            int index = 1;
            lists.RemoveAt(index);

            Console.WriteLine($"Remove 1 element by index = {index}");
            Show();

            Console.WriteLine("=============================");

            lists.InsertAt(new Product { MyProperty = 55 }, 1);

            Console.WriteLine("Insert 1 element by index");
            Show();

            Console.WriteLine("=============================");
            Console.ReadKey();
        }

        private static void Show()
        {
            foreach (var a in lists.GetElements())
            {
                Console.Write(a.MyProperty + " ");
            }
            Console.WriteLine();
        }
    }
}
