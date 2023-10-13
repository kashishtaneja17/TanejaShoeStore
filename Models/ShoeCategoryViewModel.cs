using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TanejaShoeStore.Models
{
    public class ShoeCategoryViewModel
    {
        public List<Shoe> Shoes { get; set; }
        public SelectList  Categories{ get; set; }
        public string ShoeCategory { get; set; }
        public string SearchString { get; set; }

    }
}
