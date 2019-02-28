using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Game<CardValue1> game = new Game<CardValue1>(2);
            var winner = game.PlayGame();
            Console.WriteLine("\n\n\nПОБЕДИТЕЛЬ: ");
            winner.PrintInfo();
        }
    }
}
