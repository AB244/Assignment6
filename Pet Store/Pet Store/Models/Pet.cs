using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pet_Store.Models
{
    public class Pet
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date_Recieved { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}