using System;
using CoffeeShop_Cs.models;
namespace CoffeeShop_Cs;

public class Program{
    public static void Main(){
        //Initialize Coffee Shop
        CoffeeShop shop = new CoffeeShop("Tiramisu Esspresso");
        Console.WriteLine($"Welcome to the {shop.name}");
    }
}