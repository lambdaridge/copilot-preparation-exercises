namespace CopilotExercises;

/// <summary>
/// Test script for Exercise 3 - DataProcessor implementation
/// Run this to verify your DataProcessor methods are working correctly
/// </summary>
public class DataProcessorTests
{
    public static void RunTests()
    {
        Console.WriteLine("=== Exercise 3: DataProcessor Tests ===\n");
        
        var processor = new DataProcessor();
        int passedTests = 0;
        int totalTests = 0;

        // Test data
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var emptyList = new List<int>();
        var singleNumber = new List<int> { 42 };
        var negativeNumbers = new List<int> { -5, -2, -8, -1, -10 };
        var mixedNumbers = new List<int> { -3, 5, 0, -7, 2, 9, -1 };

        // Test Sum method - normal case
        totalTests++;
        Console.Write("Test 1 - Sum([1,2,3,4,5,6,7,8,9,10]): ");
        try
        {
            int result = processor.Sum(numbers);
            if (result == 55)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Expected: 55, Got: 55)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 55, Got: {result})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test Sum method - single number
        totalTests++;
        Console.Write("Test 2 - Sum([42]): ");
        try
        {
            int result = processor.Sum(singleNumber);
            if (result == 42)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Expected: 42, Got: 42)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 42, Got: {result})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test Average method - normal case
        totalTests++;
        Console.Write("Test 3 - Average([1,2,3,4,5,6,7,8,9,10]): ");
        try
        {
            double result = processor.Average(numbers);
            if (Math.Abs(result - 5.5) < 0.001)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"PASSED (Expected: 5.5, Got: {result})");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 5.5, Got: {result})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test Average method - negative numbers
        totalTests++;
        Console.Write("Test 4 - Average([-5,-2,-8,-1,-10]): ");
        try
        {
            double result = processor.Average(negativeNumbers);
            if (Math.Abs(result - (-5.2)) < 0.001)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"PASSED (Expected: -5.2, Got: {result})");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: -5.2, Got: {result})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test FindMax method
        totalTests++;
        Console.Write("Test 5 - FindMax([1,2,3,4,5,6,7,8,9,10]): ");
        try
        {
            int result = processor.FindMax(numbers);
            if (result == 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Expected: 10, Got: 10)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 10, Got: {result})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test FindMax method - mixed numbers
        totalTests++;
        Console.Write("Test 6 - FindMax([-3,5,0,-7,2,9,-1]): ");
        try
        {
            int result = processor.FindMax(mixedNumbers);
            if (result == 9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Expected: 9, Got: 9)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 9, Got: {result})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test FindMin method
        totalTests++;
        Console.Write("Test 7 - FindMin([1,2,3,4,5,6,7,8,9,10]): ");
        try
        {
            int result = processor.FindMin(numbers);
            if (result == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Expected: 1, Got: 1)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 1, Got: {result})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test FindMin method - mixed numbers
        totalTests++;
        Console.Write("Test 8 - FindMin([-3,5,0,-7,2,9,-1]): ");
        try
        {
            int result = processor.FindMin(mixedNumbers);
            if (result == -7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Expected: -7, Got: -7)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: -7, Got: {result})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test FilterEvenNumbers method
        totalTests++;
        Console.Write("Test 9 - FilterEvenNumbers([1,2,3,4,5,6,7,8,9,10]): ");
        try
        {
            List<int> result = processor.FilterEvenNumbers(numbers);
            List<int> expected = new List<int> { 2, 4, 6, 8, 10 };
            if (result.Count == expected.Count && result.SequenceEqual(expected))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"PASSED (Expected: [2,4,6,8,10], Got: [{string.Join(",", result)}])");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: [2,4,6,8,10], Got: [{string.Join(",", result)}])");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test FilterEvenNumbers method - mixed numbers
        totalTests++;
        Console.Write("Test 10 - FilterEvenNumbers([-3,5,0,-7,2,9,-1]): ");
        try
        {
            List<int> result = processor.FilterEvenNumbers(mixedNumbers);
            List<int> expected = new List<int> { 0, 2 };
            if (result.Count == expected.Count && result.SequenceEqual(expected))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"PASSED (Expected: [0,2], Got: [{string.Join(",", result)}])");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: [0,2], Got: [{string.Join(",", result)}])");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Summary
        Console.WriteLine("\n" + new string('=', 50));
        Console.Write($"Results: {passedTests}/{totalTests} tests passed ");
        
        if (passedTests == totalTests)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ALL TESTS PASSED!");
            Console.ResetColor();
        }
        else if (passedTests >= totalTests * 0.8)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("MOSTLY PASSING - Review failed tests");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NEEDS WORK - Implement missing methods");
            Console.ResetColor();
        }
        
        Console.WriteLine(new string('=', 50) + "\n");
    }
}
