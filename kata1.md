# Legacy Code Kata 1

## Learning aims

Understand the pains of working with a badly designed legacy code base:
1. How difficult it is to have confidence in changes that aren't backed by tests
2. The difficulty/time required to implement new features

## Tasks

Implement a new feature in the legacy code base.

`Conjured` items degrade in quality twice as fast as normal items. However, this hasn't been implemented in the code base yet. **Make the necessary changes so that this is taken into account.**

The system must still be functionally correct after you have made your changes - i.e. you must not introduce any bugs!

You can change the `UpdateQuality` method and any new code you produce. You must not change the `Item` class or the `Program.Items` property.
