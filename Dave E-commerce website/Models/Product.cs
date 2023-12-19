using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dave_E_commerce_website.Data;

namespace Dave_E_commerce_website.Models
{
	public class Product
	{
		[Required]
		public string? Name { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        public int CategoryId { get; set; }
     
        public int Id { get; set; }
   
		public float Price { get; set; }

        [Required]
        public string? Color { get; set; }

        [Required]
        public int? AvailabilityInStock { get; set; }

        [Required]
        public string? ProductDescription { get; set; }

		[NotMapped]
		public IFormFile? Picture { get; set; }

        public int? Size { get; set; }

        public string? PhotoPath { get; set; }
  
	}   
}

