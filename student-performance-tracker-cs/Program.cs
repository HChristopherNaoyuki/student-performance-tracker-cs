using System;

namespace student_performance_tracker_cs
{
    // Program class: Entry point for the application
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an instance of the Solution class and run the application
                Solution solution = new Solution();
                solution.Run();
            }
            catch (Exception issue)
            {
                // If any unexpected error occurs, display it in red
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ISSUE]: {issue.Message}");
                Console.ResetColor();
            }
        }
    }
}
