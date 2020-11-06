using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.Models
{
    class Game : Naming
    {
        private Player[] _players = new Player[2];

        public Player[] Players
        {
            get { return (this._players); }
            set { this._players = value; }
        }

        public Game()
        {
            this.Name = "Game of Chess";
            Console.WriteLine(this.Name);
            Console.WriteLine($"Player {this._players[0].Name} plays against {this._players[1].Name}");

        }

        public Game(string Name)
        {
            this.Name = Name;
            Console.WriteLine(this.Name);
            Console.WriteLine($"Player {this._players[0].Name} plays against {this._players[1].Name}");
        }

        public Game(string Name, Player[] Players)
        {
            this.Name = Name;
            this._players = Players;
            Console.WriteLine(this.Name);
            Console.WriteLine($"Player {this._players[0].Name} plays against {this._players[1].Name}");
        }

        public void Start()
        {
            int TotalTime = (4 * 15) * 10; // 4 * 15" == 1' * 10 == 10'
            Clock c = new Clock(TotalTime);
            PlayerMoves(this._players[0], c);
        }

        private void PlayerMoves(Player p, Clock c)
        {
            // loop that counts till TotalTime is reached or expired
            Player p0 = p;
            for (int i = c.TotalTime; i > 0; i = i - c.TickStep)
            {
                if(p0 == this._players[0])
                {
                    Console.WriteLine($"Player {p0.Name} plays move x against Player {this._players[1].Name}");
                    p0 = this._players[1];
                }
                else
                {
                    Console.WriteLine($"Player {p0.Name} plays move x against Player {this._players[0].Name}");
                    p0 = this._players[0];
                }
                Console.WriteLine($"Remaining Time: {c.Tick()}"); 
            }

        }


    }
}
