using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BijlesPA.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Genre { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        public Developer CurrentDeveloper { get; set; }

    }
}
