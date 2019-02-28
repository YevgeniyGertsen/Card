using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp.Model
{
    public class Player<T>
    {
        public Player()
        {

        }
        public Player(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public Stack<Card<T>> Cards = new Stack<Card<T>>();
        public void PrintInfo()
        {
            Console.WriteLine("{0}", Name);
        }
    }
}
