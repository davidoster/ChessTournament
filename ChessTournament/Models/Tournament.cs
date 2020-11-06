using ChessTournament.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.Models
{
    class Tournament : Naming, ITournamentActions
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

		public Tournament(bool Active)
		{
			if (Active) this.Start();
		}

		public void Start()
		{
			this._players = new List<Player>();
			this.Name = "Ultimate Chess Tournament 2020";
			Console.WriteLine($"Welcome to the exciting world of {this.Name}");

			this.IntroToPlayer(this.Name, "Paspa", this._players);
			this.IntroToPlayer(this.Name, "Gasparov", this._players);
			this.IntroToPlayer(this.Name, "Karpov", this._players);
			this.IntroToPlayer(this.Name, "Medved", this._players);

			this._games = new List<Game>() { new Game("Game of Chess 1", new Player[2] { this._players[0], this._players[1]}),
										new Game("Game of Chess 2", new Player[2] { this._players[0], this._players[2]}),
										new Game("Game of Chess 3", new Player[2] { this._players[0], this._players[3]})};

			this._games[0].Start();


		}

		public void IntroToPlayer(string TournamentName, string PlayerName,  List<Player> players)
		{
			Console.Write($"{TournamentName} introduces ");
			Player p = new Player(PlayerName);
			players.Add(p);
		}
	}
}
