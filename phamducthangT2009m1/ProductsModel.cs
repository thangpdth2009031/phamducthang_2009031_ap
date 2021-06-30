using System;
using System.Collections.Generic;
namespace phamducthangT2009m1
{
    public class ProductsModel
    {
        private Dictionary<string, Products> _products = new Dictionary<string, Products>();
        public void Create()
        {
            Console.WriteLine("Please enter product id: ");
            var id = Console.ReadLine();
            Console.WriteLine("Please enter product name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter product price: ");
            var price = Console.ReadLine();
            _products.Add(id, new Products()
            {
                ProductsId = id,
                Name = name,
                Price = price
            });
        }

        public void Delegate()
        {
            Console.WriteLine("Please enter the product id you want to delete: ");
            var id = Console.ReadLine();
            if (_products.ContainsKey(id))
            {
                _products.Remove(id);
                Console.WriteLine("Delete successfully.");
            }
            else
            {
                Console.WriteLine("Erase failure.");
                
            }
        }

        public void Display()
        {
            Console.WriteLine("Product Id\tName\t\tPrice");
            foreach (var list in _products)
            {
                Console.WriteLine($"{list.Value.ToString()}");
            }
        }
    }
}