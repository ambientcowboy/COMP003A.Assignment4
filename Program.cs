namespace COMP003A.Assignment4;

class Program
{
    static void Main(string[] args)
    {
        /*
        * Defining integer variables to compare and count whole numbers
        in this case , the program needs whole numbers to count routine steps
        as an actual number and as they are repeated. 
        
        For this program step 3 is considered restricted and is skipped, 
        this is to demonstrate a rule-based exception when programming loops,
        preventing the loop body from skipping user iterations
            */
        int maxSteps = 6;
        int restrictedStep = 3; 
        int safetyStopsAtStep = 5;
        int nextStep = 1;
        int stepsDone = 0;
        /*
         * Bools are used to control program in response to repeated user inputs
         */
        bool safetyStopped = false;
        bool keepRunning = true;
        /*
         * do-while is used to create loop for user to continue repeating inputs
         * while remaining within the loop.
         */
        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Start/Continue Routine");
            Console.WriteLine("2. View Progress");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Enter Choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    /*
                     *if statments are used here to esnure program follows rule order (safety, max, and restricted)
                    before program continues, this enables the user to check routine steps at will.
                    */
                    if (safetyStopped)
                    {
                        Console.WriteLine("Safety limit reached. Routine stopped.");
                        break;
                    }

                    if (nextStep == safetyStopsAtStep)
                    {
                        safetyStopped = true;
                        Console.WriteLine("Safety limit reached. Routine stopped.");
                        break;
                    }

                    if (nextStep > maxSteps)
                    {
                        Console.WriteLine("Max steps reached. Routine stopped.");
                        break;
                    }

                    if (nextStep == restrictedStep)
                    {
                        Console.WriteLine("Step " + nextStep + " is restricted. Routine step skipped.");
                        nextStep++;
                        stepsDone++;
                        break;
                    }

                    Console.WriteLine("Routine step " + nextStep + " completed.");
                    nextStep++;
                    stepsDone++;

                    if (nextStep > maxSteps)
                    {
                        Console.WriteLine("Max steps reached. Routine stopped.");
                    }

                    break;
                case 2 :
                  Console.WriteLine("Current progress: " + stepsDone + " steps completed.");
                  break;
                case 3 :
                    keepRunning = false;
                    break;
            }
        } while (keepRunning);
        Console.WriteLine("Program finished.");
    }
}