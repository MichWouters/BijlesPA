using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BijlesPA.Models;

namespace BijlesPA.Repos
{
    public interface IVideoGameRepo
    {
        void AddVideoGame(VideoGame game);

        int GetVideoGameCount();
        VideoGame GetVideoGameById(int id);
    }
}
