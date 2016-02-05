using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTraining2
{
    class Game
    {
        public int GameId { get; set; }
        public int GamesPlayed { get; set; }
        public int PlayedHomeGames { get; set; }
        public int PlayedAwayGames { get; set; }
        public ICollection<Player> Players { get; set; } 
    }
}
