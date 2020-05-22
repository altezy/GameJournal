using GameJournal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameJournal.Repository
{
    public class GameRepository
    {
        public List<GameModel> GetAllGames()
        {
            return DataSourse();
        }

        public GameModel GetGameById(int id)
        {
            return DataSourse().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<GameModel> SearchGame(string title, string companyName)
        {
            return DataSourse().Where(x => x.Title.Contains(title) || x.Company.Contains(companyName)).ToList();
        }

        private List<GameModel> DataSourse()
        {
            return new List<GameModel>()
            {
                new GameModel(){Id=1, Title="ow", Company= "bliz", Description="hohoow"},
                new GameModel(){Id=1, Title="hots", Company= "bliz", Description="hohohots"},
                new GameModel(){Id=1, Title="wow", Company= "blizzard", Description="hohowow"},
                new GameModel(){Id=1, Title="dragon age", Company= "bioware", Description="hohoda"},
                new GameModel(){Id=1, Title="MA", Company= "bio", Description="hohome"}
            };
        }
    }
}
