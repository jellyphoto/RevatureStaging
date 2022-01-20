using System;
using CoffeeShop_Cs.models;
namespace CoffeeShop_Cs;

public class Program{
    public static void Main(){
        //Initialize Coffee Shop
        CoffeeShop shop = initialize();

        //Main Menu
        mainMenu(shop);
    }

    public static CoffeeShop initialize(){
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
        return shop;
    }

    public static void mainMenu(CoffeeShop shop){
        bool repeat = true;
        while(repeat){
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1 - View Menu");
            Console.WriteLine("2 - View Drinks Menu");
            Console.WriteLine("3 - View Food Menu");
            Console.WriteLine("4 - View list of Orders in Queue");
            Console.WriteLine("5 - Add Order to Queue");
            Console.WriteLine("6 - Fullfil next Order in Queue");
            Console.WriteLine("7 - View Total Amount Due for Orders in Queue");
            Console.WriteLine("8 - View Cheapest Item");
            Console.WriteLine("0 - Quit Program");

            string input = Console.ReadLine();
            switch(input){
                case "0":
                    repeat = false;
                    Console.WriteLine("\nGoodbye");
                    break;
                case "1":
                    Console.WriteLine(shop.menu.display());
                    break;
                case "2":
                    Console.WriteLine("\nDRINKS:");
                    string[] drinks = shop.drinksOnly();
                    foreach(string item in drinks)
                        Console.WriteLine(item);
                    break;
                case "3":
                    Console.WriteLine("\nFOOD:");
                    string[] food = shop.foodOnly();
                    foreach(string item in food)
                        Console.WriteLine(item);
                    break;
                case "4":
                    Console.WriteLine("\nOrders in Queue");
                    MenuItem[] orders = shop.listOrders();
                    if(orders.Length.Equals(0)){
                        Console.WriteLine("The queue is empty");
                    }else{
                        Console.WriteLine("|NAME\t\t\t|PRICE\t|");
                        Console.WriteLine("------------------------------------------------------------------");
                        foreach(MenuItem item in orders){
                            Console.WriteLine($"{item.item}\t\t\t{item.price}");
                        }
                    }                    
                    break;
                case "5":
                    Console.WriteLine("\nEnter the name of your order item");
                    string orderName = Console.ReadLine().Trim().ToLower();
                    Console.WriteLine(shop.addOrder(orderName));
                    break;
                case "6":
                    Console.WriteLine(shop.fulfillOrder());
                    break;
                case "7":
                    Console.WriteLine("Total Amount Due: {0}", shop.dueAmount());
                    break;
                case "8":
                    string cheapest = shop.cheapestItem();
                    if(cheapest is null){
                        Console.WriteLine("Unable to find the cheapest item.");
                    }else{
                        Console.WriteLine($"The cheapest item is: {cheapest}");
                    }
                    break;
                default:
                    Console.WriteLine("\nInvalid Response");
                    break;
            }
        }
    }
}