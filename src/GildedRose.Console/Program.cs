using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        private IList<Item> Items;

        private static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 7}
                }
            };

            System.Console.ReadKey();
        }

        public void UpdateQuality(IList<Item> list)
        {
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Name != "Aged Brie" && list[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (list[i].Quality > 0)
                    {
                        if (list[i].Name != "Sulfuras, Hand of Ragnaros" && list[i].Name != "Conjured Mana Cake")
                        {
                            list[i].Quality = list[i].Quality - 1;
                        } else if (list[i].Name == "Conjured Mana Cake")
                        {
                            if (list[i].Quality > 1)
                            {
                                list[i].Quality = list[i].Quality - 2;
                            }
                            else
                            {
                                list[i].Quality = 0;
                            }
                            
                        }
                    }
                }
                else
                {
                    if (list[i].Quality < 50)
                    {
                        list[i].Quality = list[i].Quality + 1;

                        if (list[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (list[i].SellIn < 11)
                            {
                                if (list[i].Quality < 50)
                                {
                                    list[i].Quality = list[i].Quality + 1;
                                }
                            }

                            if (list[i].SellIn < 6)
                            {
                                if (list[i].Quality < 50)
                                {
                                    list[i].Quality = list[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (list[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    list[i].SellIn = list[i].SellIn - 1;
                }

                if (list[i].SellIn < 0)
                {
                    if (list[i].Name != "Aged Brie")
                    {
                        if (list[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (list[i].Quality > 0)
                            {
                                if (list[i].Name != "Sulfuras, Hand of Ragnaros" && list[i].Name != "Conjured Mana Cake")
                                {
                                    list[i].Quality = list[i].Quality - 1;
                                } else if (list[i].Name == "Conjured Mana Cake"){

                                    list[i].Quality = list[i].Quality - 2;                                  
                                }
                            }
                        }
                        else
                        {
                            list[i].Quality = list[i].Quality - list[i].Quality;
                        }
                    }
                    else
                    {
                        if (list[i].Quality < 50)
                        {
                            list[i].Quality = list[i].Quality + 1;
                        }
                    }
                }
            }
        }
        
    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }
}