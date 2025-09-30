using System;

namespace Make_it_stick.models
{
    public class Questions
    {
        public int QuestionId { get; set; }

        public int quiz_Id { get; set; }

        public string Question_Text { get; set; }

        public string Type {  get; set; }

        public string Correct_Answer { get; set; }

        public bool Adaptive { get; set; }
    }
}
