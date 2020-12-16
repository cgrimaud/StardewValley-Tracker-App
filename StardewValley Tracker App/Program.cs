using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using StardewValley_Tracker_App.Models;

namespace StardewValley_Tracker_App
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var jsonOutput = JsonParser.ParseJsonIntoLocationObject();
            //MainMenu(jsonOutput);
            Menus.RoomMenu(jsonOutput);

            Console.ReadLine();

        }

        public static List<string> GetNames(List<Location> objList)
        {
            var objNames = new List<string>();
            foreach (var obj in objList)
            {
                objNames.Add(obj.Name);
                Console.WriteLine(obj.Name);
            }
            return objNames;
        }



        static void MainMenu(List<Location> locations)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Welcome to the Stardew Valley Community Center Bundle Tracker!");
            Console.WriteLine(new String('*', 60));
            Console.WriteLine("Please select a location: ");
            Console.WriteLine(new String('-', 30));
            Console.WriteLine("1. Crafts Room");
            Console.WriteLine("2. Pantry");
            Console.WriteLine("3. Fish Tank");
            Console.WriteLine("4. Boiler Room");
            Console.WriteLine("5. Bulletin Board");
            Console.WriteLine("6. Vault");
            Console.WriteLine("0. Exit");
            Console.WriteLine();
            Console.Write("Selection: ");
        }


        
    }
}
