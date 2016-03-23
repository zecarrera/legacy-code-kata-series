
using System.Collections.Generic;
using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    public class ExampleTests
    {
        [Test]
        public void RegularItemsDecreaseSellInAndQualityByOneOnUpdate()
        {
            var app = new Program();
            IList<Item> Items;
            Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}
            };
            app.UpdateQuality(Items);
            Assert.That(Items[0].Quality, Is.EqualTo(19));
            Assert.That(Items[0].SellIn, Is.EqualTo(9));
        }

        [Test]
        public void QualityIsNotNegativeForRegularItem()
        {
            var app = new Program();
            IList<Item> Items;
            Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 3, Quality = 3}
            };
            var count = 1;
            do
            {
                app.UpdateQuality(Items);
                count++;
            } while (count<=4)
            ;
            Assert.That(Items[0].Quality, Is.EqualTo(0));
        }
    }
}