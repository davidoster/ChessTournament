using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.Models
{
    class Player : Naming
    {

        public Player()
        {
            this.Name = "Player X";
            Console.WriteLine(this.Name);
        }

        public Player(string Name)
        {
            this.Name = Name;
            Console.WriteLine(this.Name);
        }
    }
}
