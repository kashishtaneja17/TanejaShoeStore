using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TanejaShoeStore.Models
{
    public class Shoe
    {
        // class has an id
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        // class has a modelname to represent the shoes title
        public string ModelName { get; set; }
        // class has a releasedate to represent that shoe has a released date
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        // class has a category (running, casual, formal, sports)
        
        
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]

        public string Category { get; set; }


        // class has a Price
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public int Ratings { get; set; }
    }
}
