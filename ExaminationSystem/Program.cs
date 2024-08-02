using System.Diagnostics;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject sub = new Subject(1, "C#");
            sub.CreateExam();
            Console.Clear();
            Console.Write("Do You Want To Start Exam ( y | n ) : ");
            char choice = char.Parse(Console.ReadLine());
            if (choice == 'y' || choice == 'Y')
            {
                Console.Clear();
                sub.SubjectExam.ShowExam(); 
            }
            else
                Console.WriteLine("Thank You");
        }
    }
}
