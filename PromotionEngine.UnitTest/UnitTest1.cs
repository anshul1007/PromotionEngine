using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PromotionEngine.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CartTotalShouldBe100()
        {
            var cart = new Cart()
            {
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Id ="A",
                        Quantity = 1
                    },
                    new Product()
                    {
                        Id = "B",
                        Quantity = 1
                    },
                    new Product()
                    {
                        Id =  "C",
                        Quantity = 1
                    }
                }
            };
            Assert.Equal(100, PromotionEngineCalculator.ApplyPromotions(cart));
        }


        [Fact]
        public void CartTotalShouldBe370()
        {
            var cart = new Cart()
            {
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Id ="A",
                        Quantity = 5
                    },
                    new Product()
                    {
                        Id = "B",
                        Quantity = 5
                    },
                    new Product()
                    {
                        Id =  "C",
                        Quantity = 1
                    }
                }
            };
            Assert.Equal(370, PromotionEngineCalculator.ApplyPromotions(cart));
        }

        [Fact]
        public void CartTotalShouldBe280()
        {
            var cart = new Cart()
            {
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Id ="A",
                        Quantity = 3
                    },
                    new Product()
                    {
                        Id = "B",
                        Quantity = 5
                    },
                    new Product()
                    {
                        Id =  "C",
                        Quantity = 1
                    },
                    new Product()
                    {
                        Id =  "D",
                        Quantity = 1
                    }
                }
            };
            Assert.Equal(280, PromotionEngineCalculator.ApplyPromotions(cart));
        }
    }
}
