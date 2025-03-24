using BijlesPA.Models;
using BijlesPA.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BijlesPA.ViewModels
{
    public class MainVM
    {
        // Dependencies bovenaan de klasse, verkies interfaces.
        private IVideoGameRepo _gameRepo;
        public MainVM(IVideoGameRepo gameRepo)
        {
            //_gameRepo = new VideoGameRepo(); // Bad practice
            // Dependencie inversions -> kant en klaar vragen niet zelf maken
            _gameRepo = gameRepo;
        }
        public VideoGame GetGameWithDiscount()
        {
            VideoGame SelectedGame = _gameRepo.GetVideoGameById(1);
            double totalPrice = SelectedGame.Prijs - (SelectedGame.Prijs * SelectedGame.Discount / 100);
            SelectedGame.Prijs = totalPrice;
            return SelectedGame;
        }

        public void AddGame(string name, double price, string genre)
        {
            if (price <= 0)
            {
                Console.WriteLine("Ongeldige prijs.");
            }
            else
            {
                VideoGame game = new VideoGame()
                {
                    Name = name,
                    Prijs = price,
                    Genre = genre
                };

                _gameRepo.AddVideoGame(game);
            }
        }
    }
}
