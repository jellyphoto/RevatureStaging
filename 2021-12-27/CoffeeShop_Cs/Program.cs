using System;
using CoffeeShop_Cs.models;
namespace CoffeeShop_Cs;

public class Program{
    public static void Main(){
        //Initialize Coffee Shop
        CoffeeShop shop = new CoffeeShop("Tiramisu Esspresso");
        Console.WriteLine($"Welcome to the {shop.name}");

        Console.WriteLine("Initializing Menu");
        shop.menu.addMenuItem("Burger", "food", 2.99);
        shop.menu.addMenuItem("Batata Vada", "food", 2.49);
        shop.menu.addMenuItem("Kale Cranberry Salad", "food", 5.49);
        shop.menu.addMenuItem("Orange Juice", "drink", 0.99);
        shop.menu.addMenuItem("Prune Soda", "drink", 1.25);
        shop.menu.addMenuItem("Oolong Tea", "drink", 1.00);

        Console.WriteLine(shop.menu.display());
    }
}