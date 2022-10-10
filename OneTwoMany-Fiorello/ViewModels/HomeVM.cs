using OneTwoMany_Fiorello.Models;
using OneTwoMany_Fiorello.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneTwoMany_Fiorello.ViewModels
{
    public class HomeVM
    {
        public SliderDetail SliderDetail { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public About About { get; set; }
        public ExpertTitle ExpertTitle { get; set; }
        public IEnumerable<Expert> Experts { get; set; }
        public Subscribe Subscribe { get; set; }
        public BlogTitle BlogTitle { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Say> Says { get; set; }
        public IEnumerable<Instagram> Instagrams { get; set; }
    }
}
