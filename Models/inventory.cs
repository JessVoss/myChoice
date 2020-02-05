using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myChoice.Models
{
    public class inventory
    {
        // item in question, department it can be found in and the amount in stock
        public string nameOfItem { get; set; }
        public string department { get; set; }
        public int numberInStock { get; set; }
    }
}