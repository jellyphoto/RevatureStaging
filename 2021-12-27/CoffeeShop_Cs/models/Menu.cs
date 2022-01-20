using System;
namespace CoffeeShop_Cs.models;

public class Menu{
    //private Dictionary<string, List<Menu>> _menuItems;
    private Dictionary<string, List<MenuItem>> _menuItems;
    public Dictionary<string, List<MenuItem>> menuItems {get{return _menuItems;}}

    public Menu(){
        _menuItems = new Dictionary<string, List<MenuItem>>();
        _menuItems.Add("food", new List<MenuItem>());
        _menuItems.Add("drink", new List<MenuItem>());
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
        _menuItems[type].Add(newItem);
    }

    public string display(){
        string view = "\n\n";
        view += "|| Menu ||";
        view += "\n";

        foreach(KeyValuePair<string, List<MenuItem>> pair in _menuItems){
            view += "\n" + pair.Key.ToUpper() + ":\n";
            foreach(MenuItem menuItem in pair.Value){
                view += menuItem.item + "\t" + menuItem.price.ToString() + "\n";
            }
        }
        return view;
    }

    public MenuItem findItemByName(string name){
        MenuItem output = null;
        bool found = false;
        foreach(string key in _menuItems.Keys){
            foreach(MenuItem item in _menuItems[key]){
                if(item.item.ToLower().Equals(name.Trim().ToLower())){
                    if(item.type.ToString().ToLower().Equals("food")){
                        output = new MenuItem();
                    }else{
                        output = new MenuItem("drink");
                    }
                    output.item = name;
                    output.price = item.price;

                    found = true;
                    break;
                }
            }
            if(found){
                break;
            }
        }
        return output;
    }

    public MenuItem findCheapestItem(){
        MenuItem output = null;
        foreach(string key in _menuItems.Keys){
            if(output is null){
                output = findCheapestItemByType(key);
            }else{
                MenuItem temp = findCheapestItemByType(key);
                if(temp.price < output.price){
                    output = temp;
                }
            }
        }
        return output;
    }

    public MenuItem findCheapestItemByType(string type){
        type = type.Trim().ToLower();
        if(_menuItems.ContainsKey(type)){
            List<MenuItem> items = _menuItems[type];

            if(items.Count.Equals(0)){
                return null;
            }

            MenuItem temp = items[0];
            for(int i=1; i<items.Count; i++){
                if(items[i].price < temp.price){
                    temp = items[i];
                }
            }

            MenuItem cheapest;
            if(type.Equals("food")){
                cheapest = new MenuItem();
            }else{
                cheapest = new MenuItem(type);
            }
            cheapest.item = temp.item;
            cheapest.price = temp.price;
            return cheapest;
        }
        else return null;
    }
}