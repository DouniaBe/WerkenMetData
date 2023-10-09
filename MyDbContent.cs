using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WerkenMetData.Moddelen;

namespace WerkenMetData
{
    public class MyDbContent : DbContext
    {
       public DbSet<Klant> Klanten {  get; set; }
        public void InitiateDatabase()
        {
           if(Klanten.Any())
           {
                Klant klant = new Klant() { Geboortedatum = DateTime.Now, Naam = "douniaaaaa", Voornaam = "-"};
               Klanten.Add(klant);
               SaveChanges();
        }
    }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=(localDb)\EvenTesten;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
    }
}
