using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.Chapter9_IteratorAndCompositePattern
{
    class MenuTestDrive
    {
        internal static void Main(string[] args)
        {
            MenuComponent pancakeMenu = new Menu("PAN CAKE MENU", "One of the worlds best pan cake");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Come and have a lovely meal");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Strong and sweet coffee");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Yummy desert");

            MenuComponent allMenu = new Menu("All MENUS", "All menus combined");
            allMenu.Add(dinerMenu);
            allMenu.Add(pancakeMenu);
            allMenu.Add(cafeMenu);            

            dinerMenu.Add(dessertMenu);

            // Add menu items
            dinerMenu.Add(new MenuItem("Butter chicken", "Chiken with thick gravy", false, 6.59));
            pancakeMenu.Add(new MenuItem("apple pan cake", "apple pan cake", true, 1.09));            
            cafeMenu.Add(new MenuItem("Cafe mocha", "our chef's special cafe", true, 3.11));
            dessertMenu.Add(new MenuItem("Kheer", "Milk and rice pudding", true, 2.99));

            Waitress waitress = new Waitress(allMenu);
            waitress.PrintMenu();
        }
    }
}
