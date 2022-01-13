using System;
namespace CoffeeShop_Cs.models;

public class Menu{
    private enum ItemType {food, drink}
    //private Dictionary<string, List<Menu>> _menuItems;
    private Dictionary<string, List<MenuItem>> menuItems {get;}

    public Menu(){
        menuItems = new Dictionary<string, List<MenuItem>>();
        menuItems.Add("food", new List<MenuItem>());
        menuItems.Add("drink", new List<MenuItem>());
    }

    //methods
    public void addMenuItem(string item, string type, double price){
        MenuItem newItem;
        if(type.ToLower().Equals("drink")){
            newItem = new MenuItem(type);
        }else{
            type = "food";
            newItem = new MenuItem();
        }
        newItem.item = item;
        newItem.price = price;
        menuItems[type].Add(newItem);
    }

    public string display(){
        string view = "\n\n";
        view += "|| Menu ||";
        view += "\n";

        foreach(KeyValuePair<string, List<MenuItem>> pair in menuItems){
            view += "\n" + pair.Key.ToUpper() + ":\n";
            foreach(MenuItem menuItem in pair.Value){
                view += menuItem.item + "\t" + menuItem.price.ToString() + "\n";
            }
        }
        return view;
    }


    //-------------------------------------------------------------------
    //MenuItem Class
    private class MenuItem{
        private string? _item;
        protected internal string? item {get {return _item;} set {_item = value;}}
        ItemType type {get;}
        private double _price;
        protected internal double price {get {return _price;} set {_price = value;}}
        protected internal MenuItem(){
            type = ItemType.food;
        }
        protected internal MenuItem(string altType1){
            type = ItemType.drink;
        }
    }
}