# BongoTesting

A comprehensive C# testing repository demonstrating unit testing best practices using multiple testing frameworks.

## Overview

This repository contains examples and exercises for learning unit testing in C# using various testing frameworks including NUnit, xUnit, and MSTest. It includes two main components:

1. **Sparky** - A simple library with various classes (Calculator, BankAccount, Customer, etc.) used for demonstrating testing concepts
2. **Bongo Test Suite** - Advanced testing examples for a study room booking system

## Technologies

- **.NET 10.0** (Sparky project)
- **.NET 6.0** (Bongo projects)
- **NUnit** - Full-featured testing framework
- **xUnit** - Modern testing framework
- **MSTest** - Microsoft's testing framework
- **Moq** - Mocking framework for unit tests

## Project Structure

```
BongoTesting/
├── Sparky/                      # Main library with classes to test
│   ├── Calculator.cs            # Basic calculator operations
│   ├── BankAccount.cs           # Banking operations
│   ├── Customer.cs              # Customer management
│   ├── GradingCalculator.cs     # Grade calculation logic
│   ├── Product.cs               # Product entity
│   ├── LogBook.cs               # Logging functionality
│   └── Fibo.cs                  # Fibonacci calculations
│
├── SparkyNUnitTest/             # NUnit test examples
├── SparkyXUnit/                 # xUnit test examples
├── SparkyMsTest/                # MSTest examples
│
├── Bongo.Core.Tests/            # Core business logic tests
├── Bongo.DataAccess.Tests/      # Data access layer tests
├── Bongo.Models.Tests/          # Model validation tests
└── Bongo.Web.Tests/             # Web layer tests
```

## Getting Started

### Prerequisites

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download) or later
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- Visual Studio 2022 or later (recommended) or VS Code with C# extension

### Building the Project

```bash
# Clone the repository
git clone https://github.com/MahmoudAbdelrahman2002/BongoTesting.git
cd BongoTesting

# Restore dependencies
dotnet restore

# Build all projects
dotnet build
```

### Running Tests

Run tests for specific test frameworks:

```bash
# Run NUnit tests
dotnet test SparkyNUnitTest/SparkyNUnitTest.csproj

# Run xUnit tests
dotnet test SparkyXUnit/SparkyXUnit.csproj

# Run MSTest tests
dotnet test SparkyMsTest/SparkyMsTest.csproj

# Run all Bongo tests
dotnet test Bongo.Core.Tests/Bongo.Core.Tests.csproj
dotnet test Bongo.DataAccess.Tests/Bongo.DataAccess.Tests.csproj
dotnet test Bongo.Models.Tests/Bongo.Models.Tests.csproj
dotnet test Bongo.Web.Tests/Bongo.Web.Tests.csproj
```

Run all tests at once:

```bash
dotnet test
```

## Testing Concepts Covered

- **Basic Assertions** - Testing return values and conditions
- **Test Cases** - Parameterized tests with multiple inputs
- **Expected Results** - Testing with inline expected values
- **Collection Testing** - Verifying lists and collections
- **Mocking** - Using Moq to isolate units of code
- **Test Fixtures** - Setup and teardown operations
- **AAA Pattern** - Arrange, Act, Assert test structure

## Example Tests

### Calculator Tests (NUnit)

```csharp
[Test]
public void Add_InputTwoIntegers_ReturnsCorrectResult()
{
    // Arrange
    Calculator calculator = new Calculator();

    // Act
    int result = calculator.AddNumbers(10, 5);
    
    // Assert
    Assert.AreEqual(15, result);
}

[TestCase(11, ExpectedResult = true)]
[TestCase(12, ExpectedResult = false)]
public bool IsOdd_InputOddOrEvenNumber_ReturnsTrue(int input)
{
    Calculator calculator = new Calculator();
    return calculator.IsOdd(input);
}
```

## Contributing

This is a learning repository. Feel free to fork and experiment with your own test cases and implementations.

## License

This project is for educational purposes.
