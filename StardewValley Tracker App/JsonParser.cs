using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using StardewValley_Tracker_App.Models;

namespace StardewValley_Tracker_App
{
	class JsonParser
    {

      
        public static List<Location> ParseJsonIntoLocationObject()
        {
            string pathToJson = @"C:\Users\chris\source\repos\StardewValley Tracker App\StardewValley Tracker App\locations.json";

            string json = File.ReadAllText(pathToJson);

            List<Location> locations = JsonConvert.DeserializeObject<List<Location>>(json);

            return locations;
        }


        //static void SaveObjects(List<Location> locationsToSave)
        //{
        //    foreach (Location location in locationsToSave)
        //    {
        //        foreach (Bundle bundle in location.Bundles)
        //        {
        //            foreach (Item item in bundle.Items)
        //            {
        //                SaveItem(item);
        //            }

        //            SaveBundle(bundle);
        //        }

        //        SaveLocation(location);
        //    }
        //}

        //static void SaveLocation(Location location)
        //{
        //    //need to implement saving to database
        //}

        //static void SaveBundle(Bundle bundle)
        //{
        //    //need to implement saving to database
        //}

        //static void SaveItem(Item item)
        //{
        //    //need to implement saving to database
        //}

        


    }
}