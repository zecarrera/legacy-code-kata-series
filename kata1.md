# Legacy Code Kata 1

Refer to the [readme.md](README.md) for an overview of the kata series and the code base we're working on.

## Learning aims

Understand the pains of working with a badly designed legacy code base:

  1. How difficult it is to have confidence in changes that aren't backed by tests
  2. The difficulty/time required to implement new features

## Tasks

Implement "Conjured" items in the code base. You may change the `UpdateQuality` method and any new code you produce. You must not change the `Item` class or the `Program.Items` property.

`Conjured` items are a concept that already exist in the code base. They behave in exactly the same way as normal items, except that they degrade in quality twice as fast. However, this double speed degradation hasn't been implemented in the code base yet. **Make the necessary changes so that `Conjured` items degrade twice as fast as normal items.**

The system must still be functionally correct after you have made your changes - i.e. you must not introduce any bugs!

Make notes about the methodology you choose to change the system to add this new feature, and on your methods for ensuring correctness. We will be discussing these at the end of the first kata period. 
