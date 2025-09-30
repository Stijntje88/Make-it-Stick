using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_it_stick.Data
{
    internal class leaderboard
    {
        public int LeaderboardId { get; set; }
        public int QuizId { get; set; }
        public int ChallengeId { get; set; }
        public int StudentId { get; set; }
        public int Score { get; set; }
        public int Rank { get; set; }
        public DateTime DateTime { get; set; }
    }
}
