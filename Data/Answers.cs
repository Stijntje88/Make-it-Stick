using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_it_stick.Data
{
    public class Answers
    {
        public int Id { get; set; }
        

        public int StudentId { get; set; }

        public int QuestionsuestionId { get; set; }

        public string Question_Text { get; set; }

        public string Correct { get; set; }

        public DateTime Datum_entered { get; set; }
    }
}
