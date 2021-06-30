using System;

namespace phamducthangT2009m1
{
    public class Products
    {
        public string ProductsId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public override string ToString()
        {
            return $"{ProductsId}               {Name}         {Price}";
        }
    }
}