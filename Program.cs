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
        bool safetyStop = false;
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
            }
        } while (keepRunning);
    }
}