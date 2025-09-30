using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_it_stick.Data
{
    internal class feedback
    {
        public int FeedBackId {  get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public int QuizId { get; set; }
        public int Level { get; set; }
        public int Score { get; set; }
        public string Commentary { get; set; }
        public DateTime DateTime { get; set; }
    }
}
