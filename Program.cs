namespace Prog_120_W24_L7_02202024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Loops - A block of code, that will repeat over and over until a condition is false
            // Keywords: while
            // while loop takes a bool, or a true or false statement
            // while ( true ) run
            // while ( false ) don't run
            // while (true) creates an INFINITE LOOP

            bool isRunning = true;

            Console.WriteLine("Before our while loop");

            //while (isRunning) // <----- 
            //{
            //    Console.WriteLine("Hi Adam");

            //    Console.Write("Press e to exit: ");
            //    string userInput = Console.ReadLine();

            //    if(userInput == "e")
            //    {
            //        isRunning = false;
            //    }
            //}

            int count = 0;

            // if my count is LESS THAN 5, keep running, and increment by1
            // Condition is count is less than 5, keep running

            // 

            Console.Write("Enter a starting number: ");
            string userNumber = Console.ReadLine();
            int startingNumber = int.Parse(userNumber);

            Console.Write("Enter an ending number: ");
            userNumber = Console.ReadLine();
            int endNumber = int.Parse(userNumber);

            int numberOfElements = endNumber - startingNumber + 1;

            double sum = 0;

            while (startingNumber <= endNumber)
            {
                Console.WriteLine(startingNumber);
                // sum = sum + startingNumber;
                sum += startingNumber;

                startingNumber++;
                //Console.WriteLine(count);
                //count++;

            } // End of while for a count

            double average = sum / (double)numberOfElements;
            Console.WriteLine("Average of numbers is: " + average);

            Console.WriteLine("After our while loop");
            // while
            // do while




            // for 


        } // Main

        // This is just after main

        // Method

        // Keywords: public static void MethodName(method parameters / arguements)
        // Names STARTS with an uppercase, first letter of every word starts with an uppercase
        public static void FirstMethod()
        {
            Console.WriteLine("This ran with my First Method call");
        } // FirstMethod()

        // Method with Parameters
        // Parameters are passed inside the parentheses
        public static void DisplayName(string userName)
        {
            // Your name is + usersName
            Console.WriteLine(userName + " is currently running this program.");
        } // DisplayName()

        // Method with a return
        // Added two parameters to pass in 2 numbers
        // Return
        // Keyword Return
        // public static RETURN TYPE name paramters
        // NOT ALL CODE PATHS RETURN A VALUE
        public static int AddTwoNumbers(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;
        }

        public static void MethodExample()
        {
            Console.WriteLine("This is the start of main");

            int addingNumbers = AddTwoNumbers(7, 8);

            int sum = AddTwoNumbers(addingNumbers, 10);

            Console.WriteLine(sum);
        }



        public static void SwitchExample()
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

            switch (userInput) // <--- What do i put here
            {
                case "1": // First Block of code that runs if the user types "1"
                    //Console.WriteLine("Your Name is Adam");
                    DisplayName("Adam");
                    break; // End of our case for "1"
                case "2":
                    //Console.WriteLine("Your name is Arevalo");
                    DisplayName("Arevalo");
                    break;
                case "3":
                    //Console.WriteLine("Your name is Will");
                    DisplayName("Will");
                    break;
                default: // Default runs when no other case runs
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

        } // SwitchExample()

    } // class

} // namespace
