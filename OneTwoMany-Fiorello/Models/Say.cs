using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneTwoMany_Fiorello.Models
{
    public class Say : BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
