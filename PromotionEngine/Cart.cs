using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PromotionEngine
{

    public static class PromotionEngineCalculator
    {
        private static readonly Dictionary<string, double> skus = new Dictionary<string, double>()
        {
            { "A", 50 },
            { "B", 30 },
            { "C", 20 },
            { "D", 15 }
        };

        public static readonly List<Rule> rules = new List<Rule>()
        {
            new Rule()
            {
                Condition = new Dictionary<string, int>()
                {
                    { "A", 3 }
                },
                Reward = 130
            },

            new Rule()
            {
                Condition = new Dictionary<string, int>()
                {
                    { "B", 2 }
                },
                Reward = 45
            },

            new Rule()
            {
                Condition = new Dictionary<string, int>()
                {
                    { "C", 1 },
                    { "D", 1 }
                },
                Reward = 30
            }
        };

        public static double ApplyPromotions(Cart cart)
        {
            return cart.Products.Sum(x => x.Quantity * skus[x.Id]);
        }

    }

    public class Rule
    {
        public Dictionary<string, int> Condition { get; set; }
        public int Reward { get; set; }
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
