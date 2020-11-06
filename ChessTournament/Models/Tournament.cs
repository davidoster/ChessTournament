using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.Models
{
    class Tournament : Naming
    {
		private List<Game> _games;

		public List<Game> Games
		{
			get { return _games; }
			set { _games = value; }
		}

		private List<Player> _players;

		public List<Player> Players
		{
			get { return _players; }
			set { _players = value; }
		}

		public Tournament()
		{
			this.Start();
		}

		private void Start()
		{
			_players = new List<Player>();
			Player p0, p1, p2, p3;

			this.Name = "Ultimate Chess Tournament 2020";
			Console.WriteLine($"Welcome to the exciting world of {this.Name}");
			
			Console.Write($"{this.Name} introduces ");
			p0 = new Player("Paspa");
			this._players.Add(p0);
			
			Console.Write($"{this.Name} introduces ");
			p1 = new Player("Gasparov");
			this._players.Add(p1);
			
			Console.Write($"{this.Name} introduces ");
			p2 = new Player("Karpov");
			this._players.Add(p2);

			Console.Write($"{this.Name} introduces ");
			p3 = new Player("Medved");
			this._players.Add(p3);

			this._games = new List<Game>() { new Game("Game of Chess 1", new Player[2] { p0, p1}), 
				                        new Game("Game of Chess 2", new Player[2] { p0, p2}), 
				                        new Game("Game of Chess 3", new Player[2] { p0, p3})};

			this._games[0].Start();
			
			
		}
	}
}
