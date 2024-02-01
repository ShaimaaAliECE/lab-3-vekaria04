using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        public int Value { get; set; }

        public Coin(String d, int score, int value) : base(d, score)
        {
            Value = value;
        }

        public override void Display()
        {
            Console.WriteLine($"{GetType().Name} {Description} is displayed");
        }

        public void UpdateTotalValue(int v)
        {
            Board.TotalValue = Board.TotalValue + v;
            Console.WriteLine("Total Value updated to: " + Board.TotalValue);
        }

        public override void AddMe(List<Collectable> c)
        {
            base.AddMe(c);
            UpdateTotalValue(Value);
        }
    }

}
