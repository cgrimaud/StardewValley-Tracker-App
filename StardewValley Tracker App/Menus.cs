using StardewValley_Tracker_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StardewValley_Tracker_App
{
    class Menus
    {
        private static readonly string MAIN_MENU_HEADER = "Please Select a Location:";
        public static void RoomMenu(List<Location> locations)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Welcome to the Stardew Valley Community Center Bundle Tracker!");
            Console.WriteLine(new String('*', 60));


            var header = MAIN_MENU_HEADER;
            var options = new List<string>();

            foreach (var location in locations)
            {
                options.Add(location.Name);
            }

            var userInput = PrintMenu(header, options);
            //if user input is -1 close program with a goodbye message or something;
            if(userInput == -1)
            {
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
            }
            else
            {
                BundleMenu(locations[userInput].Bundles);
            }
            
            
        }

        public static void BundleMenu(List<Bundle> bundles)
        {
            var header = "Please Select a Bundle:";
            var options = new List<string>();

            foreach (var bundle in bundles)
            {
                options.Add(bundle.Name);
            }

            var userInput = PrintMenu(header, options);
            
            if(userInput == -1)
            {
                // return to RoomMenu
                RoomMenu(JsonParser.ParseJsonIntoLocationObject());
            } else
            {
                ItemMenu(bundles[userInput].Items);
            }
            
            
        }

        private static void ItemMenu(List<Item> items)
        {
            var header = "Please Select an Item:";
            var options = new List<string>();

            foreach (var item in items)
            {
                options.Add(item.Name);
            }

            var userInput = PrintMenu(header, options);
            //if user input is -1 return to previous BundleMenu;
            if (userInput == -1)
            {
                // return to BundleMenu
                Console.WriteLine("Return to the BundleMenu");
            } else
            {
                Console.WriteLine("You've donated the item!");
            }
            // else, 'mark' item as donated somehow - Python project just popped up a message saying "you've donated the [item.name]

        }

        private static int PrintMenu(string header, List<string> options)
        {
            Console.Clear();
            Console.WriteLine(header);
            Console.WriteLine(new String('-', 30));
            for (var i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {options[i]}");
            }

            if (header == MAIN_MENU_HEADER)
            {
                Console.WriteLine("0) Exit");
            }
            else
            {
                Console.WriteLine("0) Go Back");
            }

            Console.Write("Selection: ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            return userInput - 1;
        }
    }
}
