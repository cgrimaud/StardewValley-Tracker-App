using System;
using System.Collections.Generic;
using System.Text;

namespace StardewValley_Tracker_App.Models
{

    public class Bundle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; }
        public int AmtToComplete { get; set; }
        public string Reward { get; set; }
        public string Image { get; set; }
        public bool Completed { get; set; }
    }

}
