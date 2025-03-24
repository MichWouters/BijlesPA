using BijlesPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BijlesPA.Repos
{
    public class VideoGameRepo
    {
        private List<VideoGame> Mygames = new List<VideoGame>();

        VideoGame Eldenring = new VideoGame()
        {
            Id = 1,
            Name = "Eldenring",
            Genre = "Actie",
            Price = 30,
            Discount = 15

        };
        VideoGame Ark = new VideoGame()
        {
            Id = 2,
            Name = "Ark",
            Genre = "Survival",
            Price = 35,
            Discount = 10

        };

        public VideoGameRepo()
        {
            Mygames.Add(Eldenring);
            Mygames.Add(Ark);
        }


    }

    //repository: klasse die communiceert met een datasource.
}
