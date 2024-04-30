using System;
using SDC1_Knowledge_Check_2.Games;

namespace SDC1_Knowledge_Check_2
{
	internal class GameLogic
	{
		private List<Game> _games;
		private Dictionary<string, VideoGame> _videoGame;

		public GameLogic()
		{
			_games = new List<Game>();
			_videoGame = new Dictionary<string, VideoGame>();
		}

		public void AddGame(Game game)
		{
			if (game is VideoGame)
			{
				_videoGame.Add(game.Name, game as VideoGame);
			}
			_games.Add(game);
		}
	}
}

