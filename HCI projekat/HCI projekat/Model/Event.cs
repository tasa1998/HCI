using System;
using System.Collections.Generic;

namespace HCI_projekat.Model
{
    public class Event
    {
        public string Mark { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Attendance { get; set; }
        public string Icon { get; set; }
        public DateTime Date { get; set; }
        public Boolean Humanitarian { get; set; }
        public int Price { get; set; }
        public string Country { get; set; }
        public string City { get; set; }    
        public double x { get; set; }
        public double y { get; set; }
        public List<Label> labels { get; set; }

    }
}
