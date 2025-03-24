using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BijlesPA.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BijlesPA.Repos
{
    public class VideoGameRepo : BaseRepository, IVideoGameRepo
    {
        private List<VideoGame> Mygames = new List<VideoGame>();

        VideoGame Eldenring = new VideoGame()
        {
            Id = 1,
            Name = "Eldenring",
            Genre = "Actie",
            Prijs = 30,
            Discount = 15
        };

        VideoGame Fortnite = new VideoGame()
        {
            Id = 2,
            Name = "Fortnite",
            Genre = "Actie",
            Prijs = 60,
            Discount = 30
        };

        public VideoGameRepo()
        {
            Mygames.Add(Eldenring);
            Mygames.Add(Fortnite);
        }

        public void AddVideoGame(VideoGame game)
        {
            string query = @"
        INSERT INTO dbo.Table (Genre, Name, Prijs, Discount) 
        VALUES (@Genre, @Name, @Prijs, @Discount)";

            var Parameters = new
            {
                @Genre = game.Genre,
                @Name = game.Name,
                @Prijs = game.Prijs,
                @Discount = game.Discount
            };
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                int affectedRows = connection.Execute(query, Parameters);
            }
        }

        public VideoGame GetVideoGameById(int id)
        {
            VideoGame game = Mygames[id];
            return game;
        }

        public int GetVideoGameCount()
        {
            int totaal = Mygames.Count;
            return totaal;
        }
    }

    //Repository: klasse die communiceert met een data source
}

