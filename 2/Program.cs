using System;

namespace Challenge_Yourself_No1_2
{
    class CapitalizeFirst
    {
        static void Main()
        {
            while (true)
            {
                // Prompt user for their name
                Console.Write("What is your name? "); 

                string input = Console.ReadLine();

                // Create boolean variable
                bool check_input = Char.IsUpper(input, 0);
            
                if (check_input == true) // If the first letter is capitalize do this
                {
                    Console.WriteLine("Hello, {0}!", input); // Print message
                    break; // Exit loop
                }
                else // If not, do this
                {
                    // Show error message and loop back to ask user for name again
                    Console.WriteLine("Please capitalize the first letter of your name.");
                }
            }

            Console.ReadLine();
        }
    }
}
