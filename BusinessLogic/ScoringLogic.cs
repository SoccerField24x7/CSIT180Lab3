using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfScores.BusinessLogic
{
    class ScoringLogic
    {
        public string PlayerName { get; set; }
        public int[] Scores;
        private const int NUM_HOLES = 18;
        private int CurrentHole = 0;

        public ScoringLogic(string playerName)
        {
            // create storage for the scores
            this.Scores = new int[NUM_HOLES];

            // assign the player's name to the public property
            this.PlayerName = playerName;
        }

        public void AddNextScore(int score)
        {
            // the UI should catch this, but just in case disallow 0
            if (score == 0)
            {
                throw new Exception("Number of strokes cannot be 0");
            }

            this.Scores[CurrentHole++] = score;
        }

        public int GetHoleScore(int hole)
        {
            return this.Scores[hole];
        }

        public int GetHoleCount()
        {
            return this.CurrentHole;
        }

        public int GetTotalScore()
        {
            int total = 0;

            // add the scores
            for(int i=0; i < this.CurrentHole; i++)
            {
                total += this.Scores[i];
            }

            return total;
        }
    }
}
