using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    public class Film
    {
        
        public int Id { get; set; }
        public int Time { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}