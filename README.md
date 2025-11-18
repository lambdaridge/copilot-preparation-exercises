# Copilot Exercises - C# Console Application

This is a simple C# console application designed for hands-on practice with GitHub Copilot's key features. Build a complete application with a Calculator, Task Manager, and Data Processor while learning to leverage Copilot effectively.

## Quick Start

### Visual Studio 2022
1. Open `CopilotExercises.csproj`
2. The project will have build errors initially - this is expected!
3. Complete the exercises to fix the errors
4. Press F5 to build and run the test suite

### Visual Studio Code
1. Open this folder in VS Code
2. Open the integrated terminal
3. Run `dotnet build` - expect build errors initially
4. Complete the exercises to implement the missing methods
5. Run `dotnet run` to execute the automated tests

## What's Included

### Exercise Files by Topic:

**Exercise 1: Inline Suggestions** (Copilot Completions)
- `Exercise1-InlineSuggestions/Calculator.cs` - Basic arithmetic operations with TODO comments
- `Exercise1-InlineSuggestions/CalculatorTests.cs` - Automated test suite with color-coded results

**Exercise 2: Chat Ask Mode** (Learn by Asking)
- `Exercise2-ChatAskMode/TaskManager.cs` - Task management with method stubs throwing NotImplementedException
- `Exercise2-ChatAskMode/TaskManagerTests.cs` - Automated test suite for task operations

**Exercise 3: Chat Agent Mode** (Let Copilot Make Changes)
- `Exercise3-ChatAgentMode/DataProcessor.cs` - Data analysis methods with NotImplementedException placeholders
- `Exercise3-ChatAgentMode/DataProcessorTests.cs` - Automated test suite for data processing

**Core Project Files:**
- `Program.cs` - Main entry point that runs all test suites
- `CopilotExercises.csproj` - .NET 8.0 project configuration
- `EXERCISES.md` - Comprehensive step-by-step instructions with prompts and tips

## Project Structure

Each exercise starts with incomplete implementations:
- **Exercise 1:** Methods exist as TODO comments only
- **Exercise 2:** Methods have signatures but throw NotImplementedException
- **Exercise 3:** Methods have signatures but throw NotImplementedException

Complete all exercises to build a fully functional application with automated testing.

## Getting Started

See **[EXERCISES.md](EXERCISES.md)** for detailed step-by-step instructions, including specific prompts and best practices for each Copilot feature.

## Requirements

- .NET 8.0 SDK or later
- Visual Studio 2022 or VS Code with C# extension
- GitHub Copilot extension installed and activated
- Active GitHub Copilot subscription

## Learning Objectives

By completing these exercises, you will learn to:
- Use inline suggestions for rapid code completion
- Ask Copilot questions to understand implementation approaches
- Let Copilot make direct code changes through Agent Mode
- Leverage comments and context to guide Copilot's suggestions
- Review and validate AI-generated code effectively
