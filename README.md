# LeetCode Solutions & Tests

This repository contains my solutions to LeetCode problems along with corresponding unit tests to ensure correctness and validate edge cases. Each LeetCode problem is implemented in C# and includes a detailed solution approach. The tests are written using the xUnit framework to facilitate easy validation and future improvements.

## Repository Structure

- **leet-code/**: Contains the C# class files for each problem.
  - Each problem has its own file or folder for organization.
  
- **leet-code.Tests/**: Contains the unit tests for the solutions using the xUnit framework.
  - Each test file corresponds to a specific problem or group of related problems.
  - Tests include edge cases and various input scenarios to validate the correctness of the solutions.

## Features

- **C# Solutions**: All LeetCode problems are solved in C# with well-commented code, making it easy to understand the approach and algorithm.
- **xUnit Tests**: For each problem, corresponding unit tests are provided. Tests ensure the solutions work for both typical and edge case inputs.
- **Efficient Algorithms**: The repository contains optimized solutions focusing on time and space complexity.
- **Problem Categories**: Problems are categorized into various sections such as:
  - Arrays
  - Strings
  - Dynamic Programming
  - Graphs
  - Trees
  - Recursion
  - Backtracking
  - etc.

## How to Use

1. Clone this repository to your local machine:
   ```bash
   git clone https://github.com/mccanncm/effective-leet-code.git

2. Navigate to the solution directory and open the project in Visual Studio or your preferred C# editor.

3. Build and run the project:
  - Use the dotnet build command to compile the solution.
  - Use the dotnet test command to run the unit tests.
  - Add new problems and solutions as you solve them!

Contributing
Contributions are welcome! If you'd like to add new solutions or improvements, feel free to fork the repository and submit a pull request. Make sure to include tests for your solutions.

Example of LeetCode Problem Structure:
```bash
leet-code/
    ├── classes/
    │   ├── TwoSumQuestion.cs         # Solution to the Two Sum problem
    │   ├── (Other problems)
leet-code.Tests/
    ├── UnitTest1.cs
    ├── ValidParenthesesTests.cs
    └── (Other test files)
