using System;
using System.ComponentModel.DataAnnotations;

static class Items
{
    public static readonly Food Bread = new Food("Bread", 20, 5, 0, 0.2);
    public static readonly Food Apple = new Food("Apple", 20, 3, 0, 0.1);
    public static readonly Food Cookie = new Food("Cookie", 40, 1, 0, 0.05);
    public static readonly Food RawBeef = new Food("Raw Beef", 20, 2, 0, 0.3);
    public static readonly Food RawPorkchop = new Food("Raw Porkchop", 20, 2, 0, 0.3);
    public static readonly Food RawChicken = new Food("Raw Chicken", 20, 2, 0, 0.3);
    public static readonly Food RawMutton = new Food("Raw Mutton", 20, 2, 0, 0.3);
    public static readonly Food Steak = new Food("Steak", 20, 8, 0, 0.3);
    public static readonly Food CookedPorkchop = new Food("Cooked Porkchop", 20, 8, 0, 0.3);
    public static readonly Food CookedChiken = new Food("Cooked Chicken", 20, 6, 0, 0.3);
    public static readonly Food CookedMutton = new Food("Cooked Mutton", 20, 8, 0, 0.3);

    public static readonly Bag LeatherBag = new Bag("Leather Bag", 300, 30, 1.0);
    public static readonly Bag ChainmailBag = new Bag("Chainmail Bag", 500, 50, 2.5);
    public static readonly Bag PlatemailBag = new Bag("Platemail Bag", 850, 85, 5.0);
    public static readonly Bag DragonleaterBag = new Bag("dragonleather Bag", 1800, 150, 3.0);
    public static readonly Backpack LeatherBackPack = new Backpack("Leather BackPack", 600, 60, 3.0);
    public static readonly Backpack ChainmailBackPack = new Backpack("Chainmail BackPack", 700, 70, 4.0);
    public static readonly Backpack PlatemailBackPack = new Backpack("Platemail BackPack", 1000, 100, 6.5);
    public static readonly Backpack DragonleaterBackPack = new Backpack("dragonleather BackPack", 2200, 200, 4.0);

}