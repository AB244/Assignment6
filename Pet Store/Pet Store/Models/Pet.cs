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
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date_Recieved { get; set; }
        [Range(0, 99999)]
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
    [Range(0,9999999)]
        public decimal Price { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImgPath { get; set; }
    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}