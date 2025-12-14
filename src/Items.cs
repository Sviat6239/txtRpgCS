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

    public static readonly Helmet LeatherHelmet = new Helmet("Leather Helmet", 2, 110, 0.5);
    public static readonly Helmet ChainmailHelmet = new Helmet("Chainmail Helmet", 4, 220, 1.0);
    public static readonly Helmet PlatemailHelmet = new Helmet("Platemail Helmet", 6, 350, 2.0);
    public static readonly Helmet IronHelmet = new Helmet("Iron Helmet", 9, 500, 2.7);
    public static readonly Helmet SteelHelmet = new Helmet("Steel Helmet", 12, 740, 3.2);
    public static readonly Helmet DragonletherHelmet = new Helmet("Dragonleather Helmet", 18, 1200, 1.5);

    public static readonly Chestplate LeatherChestplate = new Chestplate("Leather Chestplate", 6, 170, 1.5);
    public static readonly Chestplate ChainmailChestplate = new Chestplate("Chainmail Chestplate", 8, 300, 3.0);
    public static readonly Chestplate PlatemailChestplate = new Chestplate("Platemail ChestPlate", 12, 450, 5.0);
    public static readonly Chestplate IronChestplate = new Chestplate("Iron Chestplate", 15, 650, 7.0);
    public static readonly Chestplate SteelChestPlate = new Chestplate("Steel Chestplate", 18, 900, 8.5);
    public static readonly Chestplate DragonlestherChestplate = new Chestplate("Dragonleather Chestplate", 25, 1800, 3.5);

    public static readonly Leggings LeatherLeggings = new Leggings("Leather Leggings", 4, 150, 1.2);
    public static readonly Leggings ChainmailLeggings = new Leggings("chainmail Leggings", 6, 280, 2.8);
    public static readonly Leggings PlatemailLeggings = new Leggings("Platemail Leggings", 9, 420, 4.5);
    public static readonly Leggings IronLeggings = new Leggings("Iron Leggings", 12, 600, 6.5);
    public static readonly Leggings SteelLeggings = new Leggings("Steel Leggings", 15, 850, 7.3);
    public static readonly Leggings DragonleatherLeggings = new Leggings("Dragonleather Leggings", 21, 1500, 3.0);



}