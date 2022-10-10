using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneTwoMany_Fiorello.Models
{
    public class BlogTitle : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
