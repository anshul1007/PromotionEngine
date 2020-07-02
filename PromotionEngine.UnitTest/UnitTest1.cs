using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PromotionEngine.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void SkusListShouldNotBeEmpty()
        {
            Assert.Equal(4, SkuList.skus.Count);
        }

        [Fact]
        public void ShouldBeAbleToAddTheCart()
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

            Assert.Equal(3, cart.Products.Count);
        }


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
            Assert.Equal(100, cart.Products.Sum(x => x.Quantity * SkuList.skus[x.Id]));
        }
    }
}
