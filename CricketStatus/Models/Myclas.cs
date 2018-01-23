using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CricketStatus.Models
{
    public class Myclas
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> ODI { get; set; }
        public Nullable<int> Test { get; set; }
        public int Runs { get; set; }
    }
}