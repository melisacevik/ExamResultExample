internal class Program
{
    static void Main(string[] args)
    {

       

        int frstExam, scndExam,genelExam, passingGrade;

        Console.Write("Write the 1st result of the exam:  ");
        frstExam = Convert.ToInt32(Console.ReadLine());

        Console.Write("Write the 2nd result of the exam:  ");
        scndExam = Convert.ToInt32(Console.ReadLine());

        Console.Write("Write the general result of the exam:  ");
        genelExam = Convert.ToInt32(Console.ReadLine());

        passingGrade = Convert.ToInt32 (frstExam * 0.2 + scndExam * 0.3 +
        genelExam * 0.5);

        if (passingGrade > 90)

        {
        Console.WriteLine("Exam Result: " + passingGrade + " " + " You passed the lesson with \"AA\"");
        }
        else if (passingGrade > 85)
        {
        Console.WriteLine("Exam Result: " + passingGrade + " " + " You passed the lesson with \"BA\"");
        }
        else if (passingGrade > 80)
        {
        Console.WriteLine("Exam Result: " + passingGrade + " " + " You passed the lesson with \"BB\"");
        }
        else if (passingGrade > 75)
        {
        Console.WriteLine("Exam Result: " + passingGrade + " " + " You passed the lesson with \"CB\"");
        }
        else if (passingGrade > 50)
        {
        Console.WriteLine("Exam Result: " + passingGrade + " " + " You passed the lesson conditionally! ");
        }
        else
        {
        Console.WriteLine("Exam Result: " + passingGrade + " " + "You failed the lesson! " );
        }


        Console.ReadLine();



       


















    }

}