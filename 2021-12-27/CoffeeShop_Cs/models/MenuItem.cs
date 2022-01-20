using System;
namespace CoffeeShop_Cs.models;

public class MenuItem{
    public enum ItemType {food, drink}
    private string? _item;
    internal string? item {get {return _item;} set {_item = value;}}
    internal ItemType type {get;}
    private double _price;
    internal double price {get {return _price;} set {_price = value;}}
    public MenuItem(){
        type = ItemType.food;
    }
    public MenuItem(string altType1){
        type = ItemType.drink;
    }
}