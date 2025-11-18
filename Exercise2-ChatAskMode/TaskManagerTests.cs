namespace CopilotExercises;

/// <summary>
/// Test script for Exercise 2 - TaskManager implementation
/// Run this to verify your TaskManager methods are working correctly
/// </summary>
public class TaskManagerTests
{
    public static void RunTests()
    {
        Console.WriteLine("=== Exercise 2: TaskManager Tests ===\n");
        
        int passedTests = 0;
        int totalTests = 0;

        // Test AddTask and GetTaskCount
        totalTests++;
        Console.Write("Test 1 - AddTask and GetTaskCount: ");
        try
        {
            var taskManager = new TaskManager();
            taskManager.AddTask("Review code");
            taskManager.AddTask("Write documentation");
            int count = taskManager.GetTaskCount();
            
            if (count == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Expected: 2, Got: 2)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 2, Got: {count})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test GetTaskCount on empty list
        totalTests++;
        Console.Write("Test 2 - GetTaskCount on empty TaskManager: ");
        try
        {
            var taskManager = new TaskManager();
            int count = taskManager.GetTaskCount();
            
            if (count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Expected: 0, Got: 0)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 0, Got: {count})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test RemoveTask
        totalTests++;
        Console.Write("Test 3 - RemoveTask reduces count: ");
        try
        {
            var taskManager = new TaskManager();
            taskManager.AddTask("Task 1");
            taskManager.AddTask("Task 2");
            taskManager.AddTask("Task 3");
            taskManager.RemoveTask("Task 2");
            int count = taskManager.GetTaskCount();
            
            if (count == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Expected: 2, Got: 2)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 2, Got: {count})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test RemoveTask on non-existent task
        totalTests++;
        Console.Write("Test 4 - RemoveTask on non-existent task (should not crash): ");
        try
        {
            var taskManager = new TaskManager();
            taskManager.AddTask("Task 1");
            taskManager.RemoveTask("Non-existent task");
            int count = taskManager.GetTaskCount();
            
            if (count == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Handled gracefully, count still 1)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 1, Got: {count})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test ListTasks doesn't crash
        totalTests++;
        Console.Write("Test 5 - ListTasks executes without error: ");
        try
        {
            var taskManager = new TaskManager();
            taskManager.AddTask("Review code");
            taskManager.AddTask("Write documentation");
            
            // Capture console output to verify ListTasks works
            var originalOut = Console.Out;
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                taskManager.ListTasks();
                Console.SetOut(originalOut);
                
                string output = writer.ToString();
                // Check if output contains the tasks
                if (output.Contains("Review code") && output.Contains("Write documentation"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PASSED (Lists tasks correctly)");
                    Console.ResetColor();
                    passedTests++;
                }
                else if (!string.IsNullOrWhiteSpace(output))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("PARTIAL (Produces output but format may vary)");
                    Console.ResetColor();
                    passedTests++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FAILED (No output produced)");
                    Console.ResetColor();
                }
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test ListTasks on empty list
        totalTests++;
        Console.Write("Test 6 - ListTasks on empty TaskManager (should not crash): ");
        try
        {
            var taskManager = new TaskManager();
            
            var originalOut = Console.Out;
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                taskManager.ListTasks();
                Console.SetOut(originalOut);
                
                // Should complete without error
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Handles empty list gracefully)");
                Console.ResetColor();
                passedTests++;
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test adding duplicate tasks
        totalTests++;
        Console.Write("Test 7 - Add duplicate tasks: ");
        try
        {
            var taskManager = new TaskManager();
            taskManager.AddTask("Same task");
            taskManager.AddTask("Same task");
            int count = taskManager.GetTaskCount();
            
            // Both behaviors are acceptable: allow duplicates or prevent them
            if (count == 2 || count == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"PASSED (Count: {count}, behavior is acceptable)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Unexpected count: {count})");
                Console.ResetColor();
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FAILED (Exception: {ex.Message})");
            Console.ResetColor();
        }

        // Test adding and removing multiple tasks
        totalTests++;
        Console.Write("Test 8 - Add and remove multiple tasks: ");
        try
        {
            var taskManager = new TaskManager();
            taskManager.AddTask("Task 1");
            taskManager.AddTask("Task 2");
            taskManager.AddTask("Task 3");
            taskManager.AddTask("Task 4");
            taskManager.RemoveTask("Task 1");
            taskManager.RemoveTask("Task 3");
            int count = taskManager.GetTaskCount();
            
            if (count == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED (Expected: 2, Got: 2)");
                Console.ResetColor();
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"FAILED (Expected: 2, Got: {count})");
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
