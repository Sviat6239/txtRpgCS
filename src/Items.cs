using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

static class Items
{
    public static readonly Food Bread = new Food("Bread", 20, 5, 0.2);
    public static readonly Food Apple = new Food("Apple", 20, 3, 0.1);
    public static readonly Food Cookie = new Food("Cookie", 40, 1, 0.05);
    public static readonly Food RawBeef = new Food("Raw Beef", 20, 2, 0.3);
    public static readonly Food RawPorkchop = new Food("Raw Porkchop", 20, 2, 0.3);
    public static readonly Food RawChicken = new Food("Raw Chicken", 20, 2, 0.3);
    public static readonly Food RawMutton = new Food("Raw Mutton", 20, 2, 0.3);
    public static readonly Food Steak = new Food("Steak", 20, 8, 0.3);
    public static readonly Food CookedPorkchop = new Food("Cooked Porkchop", 20, 8, 0.3);
    public static readonly Food CookedChiken = new Food("Cooked Chicken", 20, 6, 0.3);
    public static readonly Food CookedMutton = new Food("Cooked Mutton", 20, 8, 0.3);



}