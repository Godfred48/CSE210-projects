using System;

class Program
{
    static void Main(string[] args)
    {
       //Assignment assignment1 = new Assignment("Taylor Bills", "C# programming language");
       //  MathAssignment mathAssignment1 = new MathAssignment("Taylor Bills", "Fractions", "Section 7.3", "Problems 8-19");
       //Console.WriteLine(mathAssignment1.GetHomeworkList());
         WritingAssignment writingAssignment1 = new WritingAssignment("Taylor Bills", "European History", "The Causes of World War II");
            Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}