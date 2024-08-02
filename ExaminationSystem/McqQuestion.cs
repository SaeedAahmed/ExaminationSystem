using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class McqQuestion : Question
    {
        // Overriding
        public override string Header
        {
            get { return "MCQ Question :"; }
        }

        public McqQuestion()
        {
            AnswerList = new Answer[4];
        }

        // Overriding Add Question Function
        public override void AddQuestion()
        {
            Console.WriteLine(Header);


            // Body of question
            Console.WriteLine("Please Enter Body Of Question :");
            Body = Console.ReadLine();

            //Mark of question

            int mark; 
            do 
            {
                Console.WriteLine("Please Enter Mark Of Question :");
            } while (!int.TryParse(Console.ReadLine() , out mark));
            Mark = mark;

            //Choices of Question
            Console.WriteLine("The Choices of Question:");
            for(int i = 0; i < 4; i++)
            {
                AnswerList[i] = new Answer
                {
                    AnswerId = i + 1
                };
                Console.Write($"Please Enter Choose number {i + 1} : ");
                AnswerList[i].AnswerText = Console.ReadLine();
            }

            //Specify right answer
            int RightAnswerId;
            do
            {
                Console.WriteLine("Please Specify The Right Choice of Question: ");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerId) && RightAnswerId < 1 || RightAnswerId > 4);

            RightAnswer.AnswerId = RightAnswerId;
            RightAnswer.AnswerText = AnswerList[RightAnswerId - 1].AnswerText;
            Console.Clear();

        }
    }
}
