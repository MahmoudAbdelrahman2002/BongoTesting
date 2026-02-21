# BongoTesting

A comprehensive .NET unit testing demonstration repository showcasing various testing frameworks and best practices.

## Overview

This repository contains example projects demonstrating unit testing in C# using multiple testing frameworks including NUnit, MSTest, and XUnit. It includes both the **Sparky** project with its test suites and **Bongo** web application tests.

## Projects

### Sparky
The main library project containing classes to demonstrate various testing scenarios:

- **Calculator**: Basic arithmetic operations and number range utilities
- **Customer**: Customer management with discount logic and greeting functionality
- **BankAccount**: Banking operations
- **Product**: Product entity
- **GradingCalculator**: Grade calculation logic
- **Fibo**: Fibonacci sequence implementation
- **LogBook**: Logging functionality

### Test Projects

The repository demonstrates three popular .NET testing frameworks:

#### 1. **SparkyNUnitTest**
Unit tests using the NUnit framework, including:
- `CalculatorNUnitTests`: Tests for calculator functionality
- `CustomerNUnitTests`: Tests for customer operations
- `BankAccountNUnitTests`: Banking logic tests
- `FiboNUnitTest`: Fibonacci tests
- `GradingCalculatorNUnitTests`: Grading system tests
- `ProductNUnitTests`: Product entity tests

#### 2. **SparkyMsTest**
Unit tests using the MSTest framework:
- `CalculatorMSTests`: Calculator functionality tests

#### 3. **SparkyXUnit**
Unit tests using the XUnit framework:
- `CalculatorXUnitTests`: Calculator tests with XUnit

### Bongo Web Application Tests

The repository also includes test projects for a web application called Bongo:

- **Bongo.Core.Tests**: Core business logic tests
- **Bongo.DataAccess.Tests**: Data access layer tests
- **Bongo.Models.Tests**: Model validation tests
- **Bongo.Web.Tests**: Web layer tests

These tests use NUnit and Moq for mocking dependencies.

## Technologies

- **.NET 10.0** (Sparky projects)
- **.NET 6.0** (Bongo test projects)
- **NUnit 3.13.2**: Feature-rich testing framework
- **MSTest**: Microsoft's testing framework
- **XUnit**: Popular open-source testing framework
- **Moq 4.16.1**: Mocking framework for unit tests
- **Entity Framework Core InMemory**: In-memory database for testing

## Getting Started

### Prerequisites

- [.NET SDK 6.0 or higher](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or Visual Studio Code (optional)

### Building the Projects

```bash
# Build all projects
dotnet build Sparky.slnx

# Build specific project
dotnet build Sparky/Sparky.csproj
```

### Running Tests

```bash
# Run all NUnit tests
dotnet test SparkyNUnitTest/SparkyNUnitTest.csproj

# Run MSTest tests
dotnet test SparkyMsTest/SparkyMsTest.csproj

# Run XUnit tests
dotnet test SparkyXUnit/SparkyXUnit.csproj

# Run all Bongo tests
dotnet test Bongo.Core.Tests/Bongo.Core.Tests.csproj
dotnet test Bongo.DataAccess.Tests/Bongo.DataAccess.Tests.csproj
dotnet test Bongo.Models.Tests/Bongo.Models.Tests.csproj
dotnet test Bongo.Web.Tests/Bongo.Web.Tests.csproj
```

## Testing Concepts Demonstrated

This repository demonstrates various unit testing concepts and patterns:

- **Arrange-Act-Assert (AAA) Pattern**: Structured test organization
- **Test Cases**: Parameterized tests using `[TestCase]` attributes
- **Mocking**: Using Moq to mock dependencies
- **Exception Testing**: Validating exception handling
- **Data-Driven Tests**: Testing with multiple input scenarios
- **In-Memory Database Testing**: Testing data access without a real database
- **Test Fixtures**: Organizing related tests

## Project Structure

```
BongoTesting/
├── Sparky/                      # Main library project
│   ├── Calculator.cs
│   ├── Customer.cs
│   ├── BankAccount.cs
│   └── ...
├── SparkyNUnitTest/            # NUnit test project
├── SparkyMsTest/               # MSTest test project
├── SparkyXUnit/                # XUnit test project
├── Bongo.Core.Tests/           # Bongo core tests
├── Bongo.DataAccess.Tests/     # Bongo data access tests
├── Bongo.Models.Tests/         # Bongo model tests
├── Bongo.Web.Tests/            # Bongo web tests
└── Sparky.slnx                 # Solution file
```

## Learning Resources

This repository is ideal for:
- Learning unit testing in .NET
- Comparing different testing frameworks (NUnit, MSTest, XUnit)
- Understanding mocking with Moq
- Practicing test-driven development (TDD)
- Studying unit testing best practices

## Contributing

Feel free to fork this repository and add your own test examples or improve existing ones.

## License

This is an educational project for learning purposes.
