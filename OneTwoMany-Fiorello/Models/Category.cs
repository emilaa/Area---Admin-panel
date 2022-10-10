using System.Collections.Generic;

namespace OneTwoMany_Fiorello.Models.Home
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
