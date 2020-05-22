using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameJournal.Data
{
    public class Games
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string AchievementCounter { get; set; }
        public string Language { get; set; }
    }
}

