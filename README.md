# Legacy Code Kata Series

This Legacy Code kata series will help you practice maintaining and refactoring legacy code. Many developers work with legacy code every day. This is often the most important code in the business, but can be notorious for lacking tests and being scary to change. We will practice techniques for bringing these code bases under control so that features can be more safely added and with less difficulty.

Our starting point is a codebase created by a no-nonsense contractor. The codebase manages the inventory for a small inn called Gilded Rose. The contractor left a System Overview which we have included at the bottom of this readme. The program automatically keeps track of the quality of goods as they approach their sell by date. We are going to try out ways of extending this system without breaking it, and perform refactorings to make further changes easier.

## Getting Started

Each kata will ask you to perform a task which should take no more than an hour or two.

Each kata starts from its own branch in the repository. The solution file in that branch has everything you need to get working on the kata straight away.

Get started with [Kata 1](kata1.md)

## System Overview

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

## Based on GildedRose by Terry Hughes

https://github.com/NotMyself/GildedRose
