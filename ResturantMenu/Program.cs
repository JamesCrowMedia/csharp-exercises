using System;
using System.Collections.Generic;

namespace ResturantMenu
{
    class Program
    {
        /* - - -  - - - - - - - - - - - - - Classes - - - - - - - - - - - - - - - - - - -*/
        class Menu /* - - - - - - - - Class for Menus - - - - - - - - - - */
        {
            private string resturantName;
            public string ResturantName
            {
                get { return resturantName; }
                private set { resturantName = value; }
            }

            private DateTime lastUpdated;
            public string LastUpdated { get { return lastUpdated.ToString(); } }
            public void MenuUpdated()
            {
                lastUpdated = DateTime.Now;
            }

            private List<MenuItem> menuItems = new List<MenuItem>();
            public List<MenuItem> MenuItems { get { return menuItems; } }

            public void AddMenuItem(string name, string desc = "", double price = 0, string category = "")
            {
                MenuItem newItem = new MenuItem(name, desc, price, category);
                menuItems.Add(newItem);
                MenuUpdated();
            }

            public MenuItem GetMenuItem(string itemName)
            {
                int index = this.MenuItems.FindIndex(x => x.Name == itemName);
                MenuItem item = this.MenuItems[index];
                return item;
            }

            public void DeleteMenuItem(string itemName)
            {
                int index = MenuItems.FindIndex(x => x.Name == itemName);
                MenuItems.RemoveAt(index);
            }

            public void EditMenuItem(string itemName, string column, string value)
            {
                double newPrice;
                bool converted;

                int index = MenuItems.FindIndex(x => x.Name == itemName);
                MenuItem item = MenuItems[index];

                if (column == "Price")
                {
                    converted = Double.TryParse(value, out newPrice);

                    if (converted)
                    {
                        item.Price = newPrice;
                    }
                    else
                    {
                        Console.WriteLine("You did not put in a valid price.");
                    }
                }
                else if (column == "Name")
                {
                    item.Name = value;
                }
                else if (column == "Desc")
                {
                    item.Desc = value;
                }
                else if (column == "Category")
                {
                    item.Category = value;
                }
                else
                {
                    Console.WriteLine("You did not put in a valid category.");
                }



            }

            public void PrintMenu()
            {
                foreach (MenuItem item in MenuItems)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            public Menu(string resturantName)
            {
                this.ResturantName = resturantName;
                this.lastUpdated = DateTime.Now;
            }

            public override string ToString()
            {
                return String.Format("Menu for {0}\nLast updated on {1}.", ResturantName, LastUpdated);
            }
        }

        class MenuItem /* - - - - - - - - Class for Menu Items - - - - - - - - - - */
        {
            private string name;
            public string Name { get { return name; } set { name = value; } }
            private string desc;
            public string Desc { get { return desc; } set { desc = value; } }
            private double price;
            public double Price { get { return price; } set { price = value; } }
            private string category;
            public string Category { get { return category; } set { category = value; } }
            private DateTime newItemCreated;
            public bool NewItem { get; private set; }

            internal MenuItem(string name, string desc = "", 
                                double price = 0, string category = "")
            {
                this.Name = name;
                this.Desc = desc;
                this.Price = price;
                this.Category = category;
                this.newItemCreated = DateTime.Now.AddDays(-31);
                this.NewItem = true;
            }

            public override string ToString()
            {
                string itsNew = "";
                if (IsNew()) { itsNew = "(New Item!)"; };
                return String.Format("{0}{1} - {2}\n{3}\n{4}\n", this.Name, 
                                        itsNew, this.Price, this.Desc, this.Category);
            }

            public bool IsNew()
            {
                if (DateTime.Now < this.newItemCreated.AddDays(30) )
                {
                    return true;
                }
                else
                {
                    this.NewItem = false;
                    return false;
                }
            }

            /* - - -  - - - - - - - - - - - - - Main - - - - - - - - - - - - - - - - - - -*/

            static void Main(string[] args)
            {
                Menu newMenu = new Menu("Dave's Fresh Mex");
                newMenu.AddMenuItem("Shrimp Taco", "A taco with shrimp.", 8.00, "Tacos");
                newMenu.AddMenuItem("Beef Taco", "A taco with beef.", 9.00, "Tacos");
                newMenu.AddMenuItem("Chicken Taco", "A taco with chicken.", 8.00, "Tacos");
                newMenu.AddMenuItem("Cheese Dip", "Melted queso served with chips.", 6.00, "Apps");
                newMenu.AddMenuItem("Chips and Salsa", "See the name.", 4.00, "Apps");
                newMenu.AddMenuItem("Fried Ice Cream", "Ice cream rolled in fried stuff.", 8.00, "Deserts");

                Console.WriteLine(newMenu.ToString() + "\n**********\n");
                newMenu.PrintMenu();

                Console.WriteLine(newMenu.GetMenuItem("Beef Taco").ToString());

                newMenu.DeleteMenuItem("Shrimp Taco");

                Console.WriteLine(newMenu.ToString() + "\n**********\n");
                newMenu.PrintMenu();

                newMenu.EditMenuItem("Beef Taco", "Name", "Ground Beef Taco");
                newMenu.EditMenuItem("Chicken Taco", "Price", "9.50");

                Console.WriteLine(newMenu.ToString() + "\n**********\n");
                newMenu.PrintMenu();

                Console.ReadLine();
            }
        }
    }
}

/*
 
    class Menu
        public  string resturantName

        private int lastUpdated
        public int LastUpdated {get}
  
        private List<MenuItem> menuItems 
        pubic List<MenuItem> GetMenu
            return menuItems
        public AddMenuItem(name desc price categry)
            create item
            add to list
        public EditMenuItem(name fieldToChange newvalue
            edit item
        public DeleteMenuItem(name)
            edit item


    class MenuItem
        name {get set}
        desc {get set}
        price {get set}
        category {get set}
     */
