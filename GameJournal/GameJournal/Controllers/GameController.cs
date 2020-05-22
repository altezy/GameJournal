using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameJournal.Models;
using GameJournal.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GameJournal.Controllers
{
    public class GameController : Controller
    {
        private readonly GameRepository _gameRepository = null;
       public GameController()
       {
           _gameRepository = new GameRepository();
       }

       public ViewResult GetAllGames()
       {
            var data = _gameRepository.GetAllGames();
            return View(data);
       }

        public ViewResult GetGame(int id)
        {
            var data = _gameRepository.GetGameById(id);
            return View(data);
        }

        public List<GameModel> SearchGames(string gameName,string companyName)
        {
            return _gameRepository.SearchGame(gameName, companyName);
        }
    }
}