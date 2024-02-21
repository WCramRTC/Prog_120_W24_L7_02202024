namespace Prog_120_W24_L7_02202024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch
            // Is another code that is a decision structure

            // Keywords: switch, case, default, break
            // swtich (argument)

            // Menu to display
            Console.WriteLine("Please Enter a Choice");
            Console.WriteLine("1. Display Adams Name");
            Console.WriteLine("2. Display Arevalos Name");
            Console.WriteLine("3. Display Wills Name");
            Console.WriteLine("4. Exit Application");

            // Ask the user for their choice
            Console.Write("Enter your choice: ");
            string userInput = Console.ReadLine();

            switch(userInput) // <--- What do i put here
            {
                case "1": // First Block of code that runs if the user types "1"
                    Console.WriteLine("Your Name is Adam");
                    break; // End of our case for "1"

                default:
                    Console.WriteLine("You did not choose a valid option");
                    break;
            } // End of switch

            Console.WriteLine("After the switch statement");
            Console.ReadKey();

            // Decision Structure if you have complicated questions
            // Just asking if 1 thing EQUALS another, you can use a switch
            //if(userInput == "1")
            //{
            //    Console.WriteLine("Your first name is Will");
            //}
            //else if(userInput == "2")
            //{
            //    Console.WriteLine("Your last name is Cram");
            //}
            //else
            //{
            //    Console.WriteLine("You are exiting the application.");
            //}




            // Method
            // TryParse

            // Loops
            // while
            // do while
            // for 


        } // Main

    } // class

} // namespace
