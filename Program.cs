using System;

namespace _8Characters
{
    class Program
    {
        static void Main(string[] args) 
            //Declare and initialize array of 8 characters then print the character elements in reverse order. ( From last element to first element)
        {
            string[] Characters = new string[8] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun", "Holiday" };

            for (int i = Characters.Length-1; i >=0; i--)
            {
                Console.WriteLine(Characters[i]);
            }
                

            
        }
        

    }
}
