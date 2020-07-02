using System;
using System.Collections;
using System.Collections.Generic;

namespace PromotionEngine
{

    public static class SkuList
    {
        public static readonly Dictionary<string, double> skus = new Dictionary<string, double>()
        {
            { "A", 50 },
            { "B", 30 },
            { "C", 20 },
            { "D", 15 }
        };
    }

    public class Cart
    {
        public List<Product> Products { get; set; }
    }

    public class Product
    {
        public string Id { get; set; }
        public int Quantity { get; set; }
    }
}
