using System;
using System.Collections;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class Cart
    {
        public List<Product> Products { get; set; }
    }

    public class Product
    {
        public Sku Id { get; set; }
        public int Quantity { get; set; }
    }

    public class Sku : IEnumerable
    {
        public string Id { get; set; }
        public double Price { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
