using System;
namespace CoffeeShop_Cs.models;

public class Menu{
    private enum ItemType {food, drink}
    private Dictionary<string, List<MenuItem>> menuItems {get;}

    public Menu(){
        menuItems = new Dictionary<string, List<MenuItem>>();
        menuItems.Add("food", new List<MenuItem>());
        menuItems.Add("drink", new List<MenuItem>());
    }


    //-------------------------------------------------------------------
    //MenuItem Class
    private class MenuItem{
        string? item {get; set;}
        ItemType type {get;}
        double price {get; set;}
        MenuItem(){
            type = ItemType.food;
        }
        MenuItem(string altType1){
            type = ItemType.drink;
        }
    }
}