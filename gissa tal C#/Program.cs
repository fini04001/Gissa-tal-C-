using System;

namespace Tal_gissning
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            int GenereratTal = slump.Next(100);
            int gissning = 101;
            int antalFörsök = 0;


            while(gissning != slumpTal)
            {
                Console.WriteLine("Guess the generated between 1 - 100 number!");
                gissning = int.Parse(Console.ReadLine());
                antalFörsök ++;

                if(gissning > GenereratTal){
                    Console.WriteLine("Too high");
                }
                else if(gissning < GenereratTal){
                    Console.WriteLine("Too low");
                }
                else{
                    Console.WriteLine("Correct! You have won!");
                    Console.WriteLine("You answered in: "+antalFörsök+" attempts");
                }
            }
        }
    }
}