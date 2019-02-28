using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp.Model
{
    public enum Suit
    {
        Hearts, //черви
        Diamonds, //буби
        Spades,//пики
        Clubs//Крести
    }
    public enum CardValue1
    {
        Six=6,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack, //Валет
        Queen, //Дама
        King,
        Ace

    }
    public enum CardValue2
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack, //Валет
        Queen, //Дама
        King,
        Ace

    }

    public class Card<T>
    {
        public Card(T CardValue, Suit Suit)
        {
            this.CardValue = CardValue;
            this.Suit = Suit;
        }
        public T CardValue { get; set; }
        public Suit Suit { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("{0} {1}\t", CardValue, Suit);
        }
    }
}
