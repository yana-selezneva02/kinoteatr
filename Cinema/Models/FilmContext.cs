using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace Cinema.Models
{
    public class FilmContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}