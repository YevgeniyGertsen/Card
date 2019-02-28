using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomUser;

namespace CardGameApp.Model
{
    public class Game<T> : CardSerivce<T>
    {
        public Game(int numPlayers)
        {
            CreateDeck();
            Shuffle();
            CreateUser(numPlayers);
            GiveCardToPlayers();
        }
        List<Player<T>> players = new List<Player<T>>();
        private void CreateUser(int numPlayers = 2)
        {
            if (numPlayers < 2)
                throw new Exception("Не может быть меньше двух игроков");
            for (int i = 0; i < numPlayers; i++)
            {
                var user = GenerateUser.GetUser();

                Player<T> player = new Player<T>();
                player.Name = String.Format("{0} {1}",
                    user.name.title, user.name.first);
                player.Id = i;

                players.Add(player);
            }

        }
        private void GiveCardToPlayers()
        {
            int countPlayers = players.Count();
            int k = 0;
            foreach (var item in cards)
            {
                if (k == countPlayers)
                    k = 0;

                players[k++].Cards.Push(item);
            }
        }
        public Player<T> PlayGame()
        {
            Dictionary<Player<T>, Card<T>> table;
            int maxCard = 0;
            Player<T> winner = null;
            while (!players.Any(a => a.Cards.Count == 36))
            {
                table = new Dictionary<Player<T>, Card<T>>();
                foreach (Player<T> item in players)
                {
                    item.Cards.Peek().PrintInfo();
                    table.Add(item, item.Cards.Pop());
                }

                Console.WriteLine("");

                foreach (var item in table)
                {
                    if (Convert.ToInt32(item.Value.CardValue) > maxCard)
                    {
                        maxCard = Convert.ToInt32(item.Value.CardValue);
                        winner = item.Key;
                    }
                }
                winner.PrintInfo();


                foreach (var item in table)
                {
                    players[winner.Id].Cards.Push(item.Value);
                }

                table = null;
                winner = null;
                maxCard = 0;
            }

            return players.FirstOrDefault(a => a.Cards.Count == 36);
        }
    }
}