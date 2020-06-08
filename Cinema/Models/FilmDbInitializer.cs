using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Cinema.Models
{
    public class FilmDbInitializer : DropCreateDatabaseAlways<FilmContext>
    {
        protected override void Seed(FilmContext db)
        {
            db.Films.Add(new Film { Name = "Лёд", Time = 120, Price = 150 });
            db.Films.Add(new Film { Name = "Соник", Time = 180, Price = 100 });
            db.Films.Add(new Film { Name = "Король лев", Time = 90, Price = 120 });
           

            base.Seed(db);
        }
    }
}