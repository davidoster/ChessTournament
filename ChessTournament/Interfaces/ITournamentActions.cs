using ChessTournament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.Interfaces
{
    interface ITournamentActions
    {
        void Start();
        void IntroToPlayer(string TournamentName, string PlayerName, List<Player> players);
    }
}
