using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;

namespace Loads
{
    public class QuestionNAnswer
    {
        public static void Main(string[] args)
        {
            /// 09/29/2022
            /// Author: Kevin Dean
            /// Title: LoadQA
            /// 
            /// Remarks: The purpose of the application is to load questions and answers for the American History program.
            /// The data are load into a LIST to be saved for future use of the program, and for further enhancements to the program.
            /// 

            string file = @"C:\DataFiles\AmerHistQA.txt";

            Console.WriteLine("          Load Questions & Answers");
            Console.WriteLine("          ---------------------------------");
            Console.WriteLine("        ");

            Console.WriteLine(" Enter American History Question:");
            string question = Console.ReadLine();
            Console.WriteLine("Enter answer to American History Question:  ");
            string answer = Console.ReadLine();

            for (int i = 0; i <= 20; i++)
            {
                File.WriteAllLines(file, question);
                File.WriteAllLines(file, answer);
            }
        }
    }

    public class QuestionsNAnswers : NewBaseType
    {
    }
}