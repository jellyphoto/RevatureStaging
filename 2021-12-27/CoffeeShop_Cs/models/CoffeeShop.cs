using System;

namespace CoffeeShop_Cs.models;

public class CoffeeShop{
    private string _name;
    public string name {get{return _name;}}
    private Menu _menu;
    public Menu menu {get{return _menu;}}
    private Queue<string> orders {get;}

    //constructor
    public CoffeeShop(string name){
        _name = name;
        _menu = new Menu();
        orders = new Queue<string>();
    }

    public string addOrder(string name){
        //adds the name of the item to the end of the orders array if it exists on the menu.
        //Otherwise, return "This item is currently unavailable!"
        return "This item is currently unavailable!";
    }

    public string fulfillOrder(){
        //if the orders array is not empty, return "The {item} is ready!".
        //If the orders array is empty, return "All orders have been fulfilled!"
        return "";
    }

    /*
    public LIST listOrders(){
        //returns the list of orders taken,
        //otherwise, an empty array.
    }
    */

    public double dueAmount(){
        //returns the total amount due for the orders taken.
        return 0;
    }

    public string cheapestItem(){
        //returns the name of the cheapest item on the menu.
        return "";
    }

    public string[] drinksOnly(){
        // returns only the item names of type drink from the menu.
        return null;
    }

    public string[] foodOnly(){
        //returns only the item names of type food from the menu.
        return null;
    }
}