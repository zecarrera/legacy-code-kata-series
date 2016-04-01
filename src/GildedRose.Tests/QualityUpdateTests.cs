
using System.Collections.Generic;
using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    public class QualityUpdateTests
    {
        private IList<Item> buildTestItem(string itemName, int sellIn, int quality)
        {
            return new List<Item>
            {
                new Item {Name = itemName, SellIn = sellIn, Quality = quality}
            };
        }

        [Test]
        public void RegularItemsDecreaseSellInAndQualityByOneOnUpdate()
        {
            var app = new Program();
            var items = buildTestItem("+5 Dexterity Vest", 10, 20);
            app.UpdateQuality(items);
            Assert.That(items[0].SellIn, Is.EqualTo(9));
            Assert.That(items[0].Quality, Is.EqualTo(19));
        }

        [Test]
        public void QualityIsNotNegativeForRegularItem()
        {
            var app = new Program();
            var items = buildTestItem("+5 Dexterity Vest", 3, 3);
            var count = 1;
            do
            {
                app.UpdateQuality(items);
                count++;
            } while (count <= 4);
            Assert.That(items[0].Quality, Is.EqualTo(0));
        }

        [Test]
        public void QualityDegradesTwiceAsFastWhenSellInHasPassedForRegularItem()
        {
            var app = new Program();
            var items = buildTestItem("+5 Dexterity Vest", -1, 4);
            app.UpdateQuality(items);
            Assert.That(items[0].Quality, Is.EqualTo(2));
        }

        [Test]
        public void QualityDegradesRegularlyWhenSellInIsOneForRegularItem()
        {
            var app = new Program();
            var items = buildTestItem("+5 Dexterity Vest", 1, 4);
            app.UpdateQuality(items);
            Assert.That(items[0].Quality, Is.EqualTo(3));
        }

        [Test]
        public void AgedBriesIncreasesQualityAsGetsOlder()
        {
            var app = new Program();
            var items = buildTestItem("Aged Brie", 2, 0);
            app.UpdateQuality(items);
            Assert.That(items[0].Quality, Is.EqualTo(1));
        }

        [Test]
        public void QualityIsNeverMoreThanFifty()
        {
            var app = new Program();
            var items = buildTestItem("Aged Brie", 1, 50);
            app.UpdateQuality(items);
            Assert.That(items[0].Quality, Is.EqualTo(50));
        }

        [Test]
        public void SulfurasQualityDoesNotDecrease()
        {
            var app = new Program();
            var items = buildTestItem("Sulfuras, Hand of Ragnaros", 1, 80);
            app.UpdateQuality(items);
            Assert.That(items[0].Quality, Is.EqualTo(80));
        }

        [Test]
        public void BackstagePassQualityIncreasesByTwoWhenThereAreTenDaysLeft()
        {
            var app = new Program();
            var items = buildTestItem("Backstage passes to a TAFKAL80ETC concert", 10, 0);
            app.UpdateQuality(items);
            Assert.That(items[0].Quality, Is.EqualTo(2));
        }

        [Test]
        public void BackstagePassQualityIncreasesByTwoWhenThereAreLessThenTenDays()
        {
            var app = new Program();
            var items = buildTestItem("Backstage passes to a TAFKAL80ETC concert", 9, 0);
            app.UpdateQuality(items);
            Assert.That(items[0].Quality, Is.EqualTo(2));
        }

        [Test]
        public void BackstagePassQualityIncreasesByThreeWhenThereAreFiveDaysLeft()
        {
            var app = new Program();
            var items = buildTestItem("Backstage passes to a TAFKAL80ETC concert", 5, 0);
            app.UpdateQuality(items);
            Assert.That(items[0].Quality, Is.EqualTo(3));
        }

        [Test]
        public void BackstagePassQualityIncreasesByTwoWhenThereAreLessThenFiveDays()
        {
            var app = new Program();
            var items = buildTestItem("Backstage passes to a TAFKAL80ETC concert", 4, 0);
            app.UpdateQuality(items);
            Assert.That(items[0].Quality, Is.EqualTo(3));
        }

        [Test]
        public void BackstagePassQualityIsZeroWhenSellInDateIsZero()
        {
            var app = new Program();
            var items = buildTestItem("Backstage passes to a TAFKAL80ETC concert", 0, 10);
            app.UpdateQuality(items);
            Assert.That(items[0].Quality, Is.EqualTo(0));
        }
    }
}