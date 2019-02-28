using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp.Model
{
    public abstract class CardSerivce<T>
    {
        protected List<Card<T>> cards = new List<Card<T>>();
        public void CreateDeck()
        {
            foreach (var cv in (T[])Enum.GetValues(typeof(T)))
            {
                foreach (var s in (Suit[])Enum.GetValues(typeof(Suit)))
                {
                    cards.Add(new Card<T>(cv,s));
                }
            }
        }
        public void Shuffle()
        {
            Random rnd = new Random();
            cards.OrderBy(x => rnd.NextDouble()).ToList();
        }
        public virtual void PrintInfo()
        {
            foreach (Card<T> item in cards)
            {
                Console.WriteLine("{0} {1}", item.CardValue, item.Suit);
            }
        }   
    }
}
