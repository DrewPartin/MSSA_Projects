using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Game
{
    static class HighScoreRepository
    {
        public static HighScoresSWEntities highScores = new HighScoresSWEntities();

        public static void AddScore(ScoresSW score)
        {
            highScores.ScoresSWs.Add(score);
            highScores.SaveChanges();
        }

        public static void DeleteScore(ScoresSW score)
        {
            highScores.ScoresSWs.Remove(score);
            highScores.SaveChanges();
        }
        
        public static ScoresSW FindScore(long score)
        {
            var ls = highScores.ScoresSWs.First(l => l.Score == score);
            if (ls != null)
            {
                return ls;
            }
            else { return null; }
        }

        public static ICollection<ScoresSW> GetScores()
        {
            return highScores.ScoresSWs.ToList();
        }
    }
}
