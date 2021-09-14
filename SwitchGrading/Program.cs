using System;

namespace SwitchGrading
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinnet kasutaja sai
            //kui kasutaja sai "5", programm kuvab "Fantastic"
            //kui kasutaja sai "4", programm kuvab "Good"
            //kui kasutaja sai "3", programm kuvab "OK"
            //kui kasutaja sai "2", programm kuvab "Bad"
            //kui kasutaja sai "1", programm kuvab "Missing"
            //muul juhul programm kirjutab konsoolis "Missing"

            Console.WriteLine("Enter your grade");
            int userGrade = Convert.ToInt32(Console.ReadLine());

            switch (userGrade)
            {
                case 5:
                    Console.WriteLine("Fantastic");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 3:
                    Console.WriteLine("OK");
                    break;
                case 2:
                    Console.WriteLine("Bad");
                    break;
                case 1:
                    Console.WriteLine("Missing");
                    break;
                default:
                    Console.WriteLine("You must repeat your course");
                    break;
            }

        }
    }
}
