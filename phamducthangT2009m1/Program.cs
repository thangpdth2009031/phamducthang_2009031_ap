using System;
using System.Collections.Generic;

namespace phamducthangT2009m1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProductsModel productsModel = new ProductsModel();
            while (true)
            {
                Console.WriteLine("*************MENU************");
                Console.WriteLine("1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                Console.WriteLine("*****************************");
                Console.WriteLine("Please enter choice:");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        productsModel.Create();
                        break;
                    case 2:
                        productsModel.Display();
                        break;
                    case 3:
                        productsModel.Delegate();
                        break;
                    case 4:
                        break;
                }

                if (choice == 4)
                {
                    break;
                }
            }
        }
    }
}