using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameJournal.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Company { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string AchievementCounter { get; set; }
        public string Language { get; set; }
    }
}
