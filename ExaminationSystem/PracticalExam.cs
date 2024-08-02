using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    // 3.We want the application to accept different Question Types:
    //For Practical Exam:
    //a.MCQ
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        // Overriding on Create List Of Questions Function
        public override void CreateListOfQuestions()
        {
            listOfQuestion = new McqQuestion[NumberOfQuestion];
            for (int i = 0; i < listOfQuestion.Length; i++)
            {
                listOfQuestion[i] = new McqQuestion();
                listOfQuestion[i].AddQuestion();
            }
        }

        //Overriding in Show Exam Function
        public override void ShowExam()
        {
            // Show Exam And Take Answers From user
            foreach (var Question in listOfQuestion)
            {
                Console.WriteLine(Question);

                for (int i = 0; i < Question.AnswerList?.Length; i++)
                {
                    Console.WriteLine(Question.AnswerList[i]);
                }
                Console.WriteLine("*************************************************");

                //user Answer
                int UserAnswerId;
                do
                {
                    Console.WriteLine("Please Enter Number of your answer : ");
                } while (!int.TryParse(Console.ReadLine(), out UserAnswerId) && UserAnswerId < 1 || UserAnswerId > 4);

                Question.UserAnswer.AnswerId = UserAnswerId;
                Question.UserAnswer.AnswerText = Question.AnswerList[UserAnswerId - 1].AnswerText;
            }
                //Show the right answer after finishing the Exam
                Console.WriteLine("Right Answers: \n");
            for (int i = 0; i < listOfQuestion?.Length; i++)
            {
                Console.WriteLine($"Question ({i + 1}) : {listOfQuestion[i].Body}");
                Console.WriteLine($"Right Answer ----> {listOfQuestion[i].RightAnswer.AnswerText}");
                Console.WriteLine("-----------------------------------------------------------");
            }

        
        }
    }
}
