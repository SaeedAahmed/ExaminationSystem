﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class TFQuestion : Question
    {

        // Header Overriding
        public override string Header
        {
            get { return "True Or False Question :"; }
        }

        //constructor
        public TFQuestion()
        {
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer(1 , "True");
            AnswerList[1] = new Answer(2 , "False");
        }

        // Overriding Add Question Function
        public override void AddQuestion()
        {
            Console.WriteLine(Header);

            //Body of Question

            Console.WriteLine("Please Enter Body Of Question :");
            Body = Console.ReadLine();

            //Mark of Question
            int mark;
            do 
            {
                Console.WriteLine("Please Enter Mark Of Question : ");
            } while (!int.TryParse(Console.ReadLine(), out mark));
            Mark = mark;
            // Right Answer 
            int RightAnswerId;
            do
            {
                Console.WriteLine("Please Enter The Right Answer of Question (1 for True and 2 for False):");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerId) && RightAnswerId < 1 || RightAnswerId > 2);

            RightAnswer.AnswerId = RightAnswerId;
            RightAnswer.AnswerText = AnswerList[RightAnswerId - 1].AnswerText;
            Console.Clear();
        }
    }
}
