namespace CopilotExercises;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== GitHub Copilot Training Exercises ===\n");

        // Run Exercise 1 Tests
        CalculatorTests.RunTests();

        // Run Exercise 2 Tests
        TaskManagerTests.RunTests();

        // Run Exercise 3 Tests
        DataProcessorTests.RunTests();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
