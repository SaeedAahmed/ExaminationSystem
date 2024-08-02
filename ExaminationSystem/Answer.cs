using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Answer
    {
       // 4. We need to define a class for the answers(AnswerId, AnswerText).

        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer() { }
        public Answer(int _answerId , string _answerText)
        {
            AnswerId = _answerId;
            AnswerText = _answerText;
        }

        // Overriding ToString
        public override string ToString()
        {
            return $"{AnswerId} _ {AnswerText}";
        }

    }
}
