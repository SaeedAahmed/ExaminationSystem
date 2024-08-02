using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    //6. Design a Base class Exam describe the common attributes concerning the exam:
    //  a.Time of exam
    //  b.Number of Questions
    //  c.Show Exam Functionality that its implementations will be different for each exam based on its type.

    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestion { get; set; }
        public Question[] listOfQuestion { get; set; }
        
        //constructor
        protected Exam(int time , int numberOfQuestion)
        {
            Time = time;    
            NumberOfQuestion = numberOfQuestion;
        }

        public abstract void ShowExam();
        public abstract void CreateListOfQuestions();

    }
}
