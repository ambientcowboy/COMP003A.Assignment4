namespace COMP003A.Assignment4;

class Program
{
    static void Main(string[] args)
    {
        //This 
        int maxSteps = 6;
        int restrictedStep = 3;
        int safetyStopsAtStep = 5;
        int nextStep = 1;
        int stepsDone = 0;
        bool safetyStopped = false;
        bool keepRunning = true;
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