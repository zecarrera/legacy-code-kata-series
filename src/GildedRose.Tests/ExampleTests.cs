
using System.Collections.Generic;
using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    public class ExampleTests
    {
        private IList<Item> buildTestItem(int sellIn, int quality)
        {
            return new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality}
            };
        }

        [Test]
        public void RegularItemsDecreaseSellInAndQualityByOneOnUpdate()
        {
            var app = new Program();
            var items = buildTestItem(10, 20);
            app.UpdateQuality(items);
            Assert.That(items[0].SellIn, Is.EqualTo(9));
            Assert.That(items[0].Quality, Is.EqualTo(19));
        }

        [Test]
        public void QualityIsNotNegativeForRegularItem()
        {
            var app = new Program();
            var items = buildTestItem(3, 3);
            var count = 1;
            do
            {
                app.UpdateQuality(items);
                count++;
            } while (count <= 4);
            Assert.That(items[0].Quality, Is.EqualTo(0));
        }

    }
}