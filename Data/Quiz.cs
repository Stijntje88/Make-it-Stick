using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_it_stick.Data
{
    public class Quiz
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string DifficultyLevel { get; set; }
        public int TimeLimit { get; set; }
        public DateTime Deadline { get; set; }
        public bool OpenStatus { get; set; }
    }
}
