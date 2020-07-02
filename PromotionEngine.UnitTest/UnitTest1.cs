using System;
using System.Collections.Generic;
using Xunit;

namespace PromotionEngine.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldBeAbleDefineTheSkuList()
        {
            var skus = new List<Sku>()
            {
                new Sku()
                {
                    Id= "A", Price = 50
                },
                new Sku()
                {
                    Id= "B", Price = 30
                },
                new Sku()
                {
                    Id= "C", Price = 20
                },
                new Sku()
                {
                    Id= "D", Price = 15
                },
            };

            Assert.Equal(4, skus.Count);
        }
    }
}
