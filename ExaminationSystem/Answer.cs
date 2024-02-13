using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Answer
    {
        public int Id { get; set; }
        public string? AnswerText { get; set; }

        public Answer(int _Id,string _answerText)
        {
            Id = _Id;
            AnswerText = _answerText;

        }

    }
}
