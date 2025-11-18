namespace CopilotExercises;

/// <summary>
/// Test script for Exercise 1 - Calculator implementation
/// Run this to verify your Calculator methods are working correctly
/// </summary>
public class CalculatorTests
{
    public static void RunTests()
    {
        Console.WriteLine("=== Exercise 1: Calculator Tests ===\n");
        
        var calculator = new Calculator();
        int passedTests = 0;
        int totalTests = 0;

        // Test Add method
        totalTests++;
        Console.Write("Test 1 - Add(5, 3): ");
        try
        {
            int result = calculator.Add(5, 3);
            if (result == 8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Expected: 8, Got: 8)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 8, Got: {result})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test Subtract method
        totalTests++;
        Console.Write("Test 2 - Subtract(10, 4): ");
        try
        {
            int result = calculator.Subtract(10, 4);
            if (result == 6)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Expected: 6, Got: 6)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 6, Got: {result})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test Multiply method
        totalTests++;
        Console.Write("Test 3 - Multiply(7, 6): ");
        try
        {
            int result = calculator.Multiply(7, 6);
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

        // Test Divide method - normal case
        totalTests++;
        Console.Write("Test 4 - Divide(20, 4): ");
        try
        {
            double result = calculator.Divide(20, 4);
            if (result == 5.0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Expected: 5.0, Got: 5.0)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 5.0, Got: {result})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test Divide method - division by zero
        totalTests++;
        Console.Write("Test 5 - Divide(10, 0) [should handle division by zero]: ");
        try
        {
            double result = calculator.Divide(10, 0);
            // Check if it returns a special value or throws exception
            if (double.IsInfinity(result) || double.IsNaN(result))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Returns special value for division by zero)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"WARNING (Got: {result}, but should handle division by zero)");
                Console.ResetColor();
            }
        }
        catch (DivideByZeroException)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PASSED (Throws DivideByZeroException)");
            Console.ResetColor();
            passedTests++;
        }
        catch (ArgumentException)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PASSED (Throws ArgumentException for division by zero)");
            Console.ResetColor();
            passedTests++;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"PARTIAL (Throws {ex.GetType().Name}, consider using DivideByZeroException or ArgumentException)");
            Console.ResetColor();
            passedTests++;
        }

        // Test Divide with decimal precision
        totalTests++;
        Console.Write("Test 6 - Divide(10, 3) [decimal precision]: ");
        try
        {
            double result = calculator.Divide(10, 3);
            if (Math.Abs(result - 3.333333) < 0.001)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"PASSED (Expected: ~3.333, Got: {result:F6})");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: ~3.333, Got: {result})");
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
