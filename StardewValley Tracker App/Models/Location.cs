using System;
using System.Collections.Generic;
using System.Text;

namespace StardewValley_Tracker_App.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Bundle> Bundles { get; set; }
        public string Reward { get; set; }
        public bool Completed { get; set; }
    }
}
