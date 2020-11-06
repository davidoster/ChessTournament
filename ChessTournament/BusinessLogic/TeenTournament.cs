using ChessTournament.Interfaces;
using ChessTournament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.BusinessLogic
{
    class TeenTournament : Tournament
    {
		public TeenTournament() : base(false)
		{
			this.Start();
		}

		public new void Start()
		{
			this.Players = new List<Player>();
			this.Name = "Teen Chess Tournament 2020";
			Console.WriteLine($"Welcome to the exciting world of {this.Name}");

			this.IntroToPlayer(this.Name, "Paspa", this.Players);
			this.IntroToPlayer(this.Name, "Gasparov", this.Players);

			this.Games = new List<Game>() { new Game("Game of Chess 1", new Player[2] { this.Players[0], this.Players[1] }) };

			this.Games[0].Start();
		}
	}
}
