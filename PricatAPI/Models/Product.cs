﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PricatAPI.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Imagen")]
        public string ImageName { get; set; } = null!;

        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; } = null!;

        [Display(Name = "Descripcion")]
        public string Description { get; set; } = null!;

        [Required]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }
    }
}
