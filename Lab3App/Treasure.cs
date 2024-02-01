using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Treasure : Collectable {
        public Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        public int Score { get; set; }

        public virtual void UpdateTotalScore(int score)
        {
            Board.TotalScore += score;
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);

            int currentScore = (Score > 0) ? Score : 100;
            UpdateTotalScore(currentScore);
        }
    }

  
}
