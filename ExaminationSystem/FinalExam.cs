using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    // 3.We want the application to accept different Question Types:
    //For Final Exam:
    //a.True or False
    //b.MCQ(Choose one answer)
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestion) : base(time, numberOfQuestion)
        {

        }

        // Overriding on Create List Of Questions Function
        public override void CreateListOfQuestions()
        {
            listOfQuestion = new Question[NumberOfQuestion];

            for (int i = 0; i < listOfQuestion?.Length; i++)
            {
                int choice;
                do
                {
                    Console.Write("Please Enter Type Of Question (1 for MCQ | 2 for True|False ): ");
                } while (int.TryParse(Console.ReadLine(), out choice) && choice < 1 || choice > 2);
                Console.Clear();

                if (choice == 1)
                {
                    listOfQuestion[i] = new McqQuestion();
                    listOfQuestion[i].AddQuestion();
                }
                else
                {
                    listOfQuestion[i] = new TFQuestion();
                    listOfQuestion[i].AddQuestion();
                }
            }

        }

        // Overriding on Show Exam Function
        public override void ShowExam()
        {
            // Show Exam And Take Answers From user
            foreach (var Question in listOfQuestion)
            {
                //Question
                Console.WriteLine(Question);
                //Answers Of Question
                for (int i = 0; i < Question.AnswerList?.Length; i++)
                    Console.WriteLine(Question.AnswerList[i]);
                Console.WriteLine("---------------------------------------");

                //User Answer
                int UserAnswerId;
                do
                {
                    Console.WriteLine("Please Enter Number of your answer : ");
                } while (!int.TryParse(Console.ReadLine(), out UserAnswerId) && UserAnswerId < 1 || UserAnswerId > 4);

                Question.UserAnswer.AnswerId = UserAnswerId;
                Question.UserAnswer.AnswerText = Question.AnswerList[UserAnswerId - 1].AnswerText;
                Console.WriteLine("*********************************************************** \n");
            }
            Console.Clear();

            //Final Exam Shows the Questions, Answers and Grade
            int TotalMarks = 0, Grade = 0;
            Console.WriteLine("Your Answers: \n");

            for (int i = 0; i < listOfQuestion?.Length; i++)
            {
                TotalMarks += listOfQuestion[i].Mark;
                if (listOfQuestion[i].RightAnswer.AnswerId == listOfQuestion[i].UserAnswer.AnswerId)
                {
                    Grade += listOfQuestion[i].Mark;
                }
                Console.WriteLine($"Question ({i + 1}) :{listOfQuestion[i].Body}");
                Console.WriteLine($"Your Answer -----> {listOfQuestion[i].UserAnswer.AnswerText}");
                Console.WriteLine($"Right Answer -----> {listOfQuestion[i].AnswerList[i].AnswerText}");
                Console.WriteLine("----------------------------------------------------------------");
            }
            Console.WriteLine($"Your Grade Is {Grade} from {TotalMarks}");

        }
    }
}


