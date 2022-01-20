using System;

namespace CoffeeShop_Cs.models;

public class CoffeeShop{
    private string _name;
    public string name {get{return _name;}}
    private Menu _menu;
    public Menu menu {get{return _menu;}}
    private Queue<MenuItem> _orders;
    public Queue<MenuItem> orders {get{return _orders;}}

    //constructor
    public CoffeeShop(string name){
        _name = name;
        _menu = new Menu();
        _orders = new Queue<MenuItem>();
    }

    public string addOrder(string name){
        //adds the name of the item to the end of the orders array if it exists on the menu.
        //Otherwise, return "This item is currently unavailable!"
        MenuItem order = menu.findItemByName(name);
        if(order is null){
            return "This item is currently unavailable!";
        }else{
            _orders.Enqueue(order);
            return $"{name} successfully added to the queue.";
        }        
    }

    public string fulfillOrder(){
        //if the orders array is not empty, return "The {item} is ready!".
        //If the orders array is empty, return "All orders have been fulfilled!"
        if(_orders.Count.Equals(0)){
            return "All orders have been fulfilled!";
        }else{
            string item = _orders.Dequeue().item;
            return $"The {item} is ready!";
        }
    }

    public MenuItem[] listOrders(){
        //returns the list of orders taken,
        //otherwise, an empty array.
        return _orders.ToArray();
    }

    public double dueAmount(){
        //returns the total amount due for the orders taken.
        double total = 0;
        MenuItem[] ordersArr = _orders.ToArray();
        foreach(MenuItem item in ordersArr){
            total += item.price;
        }
        return total;
    }

    public string cheapestItem(){
        //returns the name of the cheapest item on the menu.
        return _menu.findCheapestItem().item;
    }

    public string[] drinksOnly(){
        // returns only the item names of type drink from the menu.
        List<MenuItem> items = _menu.menuItems["drink"];
        string[] itemNames = new string[items.Count];
        for(int i=0; i<itemNames.Length; i++){
            itemNames[i] = items[i].item;
        }
        return itemNames;
    }

    public string[] foodOnly(){
        //returns only the item names of type food from the menu.
         List<MenuItem> items = _menu.menuItems["food"];
        string[] itemNames = new string[items.Count];
        for(int i=0; i<itemNames.Length; i++){
            itemNames[i] = items[i].item;
        }
        return itemNames;
    }
}