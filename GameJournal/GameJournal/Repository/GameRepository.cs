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
                new GameModel(){Id=1, Title="Overwatch", Company= "Blizzard Entertainment", Description="Overwatch is a team-based multiplayer first-person shooter developed and published by Blizzard Entertainment. ... Players on a team work together to secure and defend control points on a map or escort a payload across the map in a limited amount of time."},
                new GameModel(){Id=1, Title="Heroes of the Storm", Company= "Blizzard Entertainment", Description="Heroes of the Storm is a crossover multiplayer online battle arena video game developed and published by Blizzard Entertainment and released on June 2, 2015, for Microsoft Windows and macOS."},
                new GameModel(){Id=1, Title="World of Warcraft", Company= "Blizzard Entertainment", Description="World of Warcraft (WoW) is a massively multiplayer online role-"},
                new GameModel(){Id=1, Title="Dragon Age:Origins", Company= "Bioware", Description="Origins is a role-playing game played from a third-person perspective. The player is a Grey Warden, part of an order of elite fighters, whose task is to defeat the Archdemon and save the world from a disastrous event called the Blight."},
                new GameModel(){Id=1, Title="Mass Effect", Company= "Bioware", Description="Mass Effect is a military science fiction media franchise based on the third-person role-playing shooter series developed by BioWare and released for the Xbox 360, PlayStation 3, and Microsoft Windows, with the third installment also released on the Wii U."},
                new GameModel(){Id=1, Title="Rust", Company= "Facepunch Studios", Description="The only aim in Rust is to survive - Overcome struggles such as hunger, thirst and cold. Build a fire. Build a shelter. Kill animals. Protect yourself from other players"}
            };
        }
    }
}
