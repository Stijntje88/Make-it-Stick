using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_it_stick.Data
{
    internal class notification
    {
        public int PushId {  get; set; }
        public int StudentId { get; set; }
        public int QuizId { get; set; }
        public DateTime DateSent { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}
