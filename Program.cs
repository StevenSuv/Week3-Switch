using System;

namespace ControlFlow_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234,
            //programm kuvab konsoolis "Welcome!"
            //kui sisustatud PIN on vale, programm kuvab konsoolis
            //"Wrong PIN. Try again"

            Console.WriteLine("Enter a PIN");
            int userPIN = Convert.ToInt32(Console.ReadLine());

            if(userPIN != 1234) //!= ei võrdu
            {
                Console.WriteLine("Wrong PIN. Try again");
            }
            else
            {
                Console.WriteLine("Welcome");
            }

        }
    }
}
