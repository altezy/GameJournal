using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameJournal.Data
{
    public class GameJournalContext : DbContext
    {
        public GameJournalContext(DbContextOptions<GameJournalContext> options)
            :base(options)
        {

        }

        public DbSet<Games> Games { get; set; }
    }
}
