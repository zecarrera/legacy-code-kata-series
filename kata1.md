# Legacy Code Kata 1

Refer to the [readme.md](README.md) for an overview of the kata series and the code base we're working on.

## Learning aims

Understand the pains of working with a badly designed legacy code base:

  1. How difficult it is to have confidence in changes that aren't backed by tests
  2. The difficulty/time required to implement new features

## Introduction

Hi and welcome to team Gilded Rose. As you know, we are a small inn with a prime location in a prominent city ran by a friendly innkeeper named Allison. We also buy and sell only the finest goods. Unfortunately, our goods are constantly degrading in quality as they approach their sell by date. We have a system in place that updates our inventory for us. It was developed by a no-nonsense type named Leeroy, who has moved on to new adventures. Your task is to add the new feature to our system so that we can begin selling a new category of items. First an introduction to our system:

- All items have a SellIn value which denotes the number of days we have to sell the item
- All items have a Quality value which denotes how valuable the item is
- At the end of each day our system lowers both values for every item

Pretty simple, right? Well this is where it gets interesting:

- Once the sell by date has passed, Quality degrades twice as fast
- The Quality of an item is never negative
- "Aged Brie" actually increases in Quality the older it gets
- The Quality of an item is never more than 50
- "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
- "Backstage passes", like aged brie, increases in Quality as it's SellIn value approaches; Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but Quality drops to 0 after the concert

We have recently signed a supplier of conjured items. This requires an update to our system:

- "Conjured" items degrade in Quality twice as fast as normal items

Just for clarification, an item can never have its Quality increase above 50, however "Sulfuras" is a legendary item and as such its Quality is 80 and it never alters.

## Tasks

Implement "Conjured" items in the code base. You may change the `UpdateQuality` method and any new code you produce. You must not change the `Item` class or the `Program.Items` property.

`Conjured` items are a concept that already exist in the code base. They behave in exactly the same way as normal items, except that they degrade in quality twice as fast. However, this double speed degradation hasn't been implemented in the code base yet. **Make the necessary changes so that `Conjured` items degrade twice as fast as normal items.**

The system must still be functionally correct after you have made your changes - i.e. you must not introduce any bugs!

Make notes about the methodology you choose to change the system to add this new feature, and on your methods for ensuring correctness. We will be discussing these at the end of the first kata period. 
