using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    public class Purchase
    {

        public int PurchaseId { get; set; }
        public string Person { get; set; }
        public string Email { get; set; }
        public int FilmId { get; set; }
        public DateTime Date { get; set; }
    }
}