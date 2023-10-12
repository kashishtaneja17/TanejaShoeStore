using System;
using System.ComponentModel.DataAnnotations;


namespace TanejaShoeStore.Models
{
    public class Shoe
    {
        // class has an id
        public int Id { get; set; }

        // class has a modelname to represent the shoes title
        public string ModelName { get; set; }
        // class has a releasedate to represent that shoe has a released date
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        // class has a category (running, casual, formal, sports)
        public string Category { get; set; }
        // class has a Price
        public decimal Price { get; set; }
        public int Ratings { get; set; }
    }
}
