using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTraining2
{
    class Championship: DbContext
    {
        public int ChampionshipId { get; set; }
        public int WonChampionships { get; set; }
        public int GoldTrophy { get; set; }
        public int SilverTrophy { get; set; }
        public int BronsTrophy { get; set; }

       public DbSet<Game>Games { get; set; }
        public DbSet<Player>Players { get; set; }

    }
}
