using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    //1. Design a Class to represent the Question Object, Question is  consisting of: 
         // a.Header of the question
         // b.Body of the question
         // c.Mark
    internal abstract class Question
    {
        public abstract string Header { get; }
        public string Body { get; set; }
        public int Mark { get; set; }

        //5. Question is associated with an Array of answers and its right answer(Answers[] AnswerList)
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }

        // Constructor
        public Question()
        {
            RightAnswer = new Answer();
            UserAnswer = new Answer();
        }

        // Methods
        public abstract void AddQuestion();
        public override string ToString()
        {
            return $"{Header} \t Mark({Mark})\n" +
                "-------------------------------------" +
                $" \n{Body}\n";
        }

    }
}
