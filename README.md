# 🔁 C# Arithmetic Calculator with Loops

A C# (.NET Core 3.1) console application that demonstrates core control
flow structures including `switch` statements, nested `if-else` blocks,
`for` loops, and `do-while` loops. The project is split across three
focused files, each highlighting a different concept.

---

## 📋 Features

- **Program1_IfElse.cs** — arithmetic calculator using nested if-else statements
- **Program2_Switch.cs** — same calculator rebuilt using a switch statement
- **Program3_LoopExamples.cs** — standalone demonstrations of for, while, nested while, and do-while loops
- Validates all numeric input — re-prompts instead of crashing on bad input
- Validates operator input — re-prompts until a valid operator is entered
- Guards against division by zero in both calculator programs
- Each file focuses on one control flow concept for clear side-by-side comparison

---

## ⚙️ How It Works

1. **Program1** — the user enters two numbers and an operator symbol; a chain
   of nested if-else statements determines and prints the result; invalid
   operators re-prompt the user until a valid one is entered
2. **Program2** — the same input flow, but a switch statement handles the
   operator matching; invalid operators re-prompt the user until a valid one
   is entered
3. **Program3** — no calculator; demonstrates four loop types with printed
   output showing each loop's behavior step by step

---

## 💡 Example Usage

**Program1 — If-Else Calculator:**
```
=== If-Else Calculator ===

Enter first numeric value:  g
  ⚠ Invalid input. Please enter a number.

Enter first numeric value:  7
Enter second numeric value: l
  ⚠ Invalid input. Please enter a number.

Enter second numeric value: 5
Enter a math operator (+, -, *, /): k
  ⚠ Invalid operator. Please enter +, -, *, or /.

Enter a math operator (+, -, *, /): -

Subtraction:    7 - 5 = 2
```

**Program2 — Switch Calculator:**
```
=== Switch Calculator ===

Enter first numeric value:  k
  ⚠ Invalid input. Please enter a number.

Enter first numeric value:  2
Enter second numeric value: l
  ⚠ Invalid input. Please enter a number.

Enter second numeric value: 900
Enter a math operator (+, -, *, /): 1
  ⚠ Invalid operator. Please enter +, -, *, or /.

Enter a math operator (+, -, *, /): 8
  ⚠ Invalid operator. Please enter +, -, *, or /.

Enter a math operator (+, -, *, /): +

Addition:       2 + 900 = 902
```

**Program3 — Loop Examples:**
```
=== Loop Examples ===

--- For Loop (0 to 4) ---
  i = 0
  i = 1
  i = 2
  i = 3
  i = 4

--- While Loop (0 to 9) ---
  Value of i: 0
  Value of i: 1
  ...
  Value of i: 9

--- Nested While Loop ---
  Outer loop — m = 0
    Inner loop — j = 0
    Inner loop — j = 1
  Outer loop — m = 1
    Inner loop — j = 0
    Inner loop — j = 1

--- Do-While Loop (always runs at least once) ---
  nn = 0
  nn = 1
  nn = 2
(Loop finished)
```

---

## 🛠️ Technologies Used

| Technology       | Purpose                                        |
|------------------|------------------------------------------------|
| C# 8.0           | Core programming language                      |
| .NET Core 3.1    | Runtime framework                              |
| Nested If-Else   | Operator selection in Program1                 |
| Switch Statement | Operator selection in Program2                 |
| For Loop         | Fixed-count iteration in Program3              |
| While Loop       | Condition-based iteration in Program3          |
| Nested Loops     | Loop-inside-a-loop demonstration in Program3   |
| Do-While Loop    | Run-at-least-once iteration in Program3        |

---

## 🎓 Learning Outcomes

- Using nested `if-else` statements for conditional branching
- Using `switch` statements as a cleaner alternative to long if-else chains
- Understanding when to use `for` vs `while` vs `do-while` loops
- Implementing input validation with `double.TryParse` to prevent crashes
- Looping on invalid input to re-prompt the user instead of exiting
- Handling edge cases like division by zero

---

## 📁 Folder Structure

```
A2-C-sharp-loops/
├── Program1_IfElse.cs
├── Program2_Switch.cs
├── Program3_LoopExamples.cs
├── A2-Program1-If-Else.png
├── A2-Program2-Switch.png
├── A3-Program3-LoopExamples.png
├── A2-C-sharp-loops.csproj
├── .gitignore
├── LICENSE
└── README.md
```

---

## 🚀 How to Run

### Prerequisites
- [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet/3.1)

### Steps

```bash
# Clone the repository
git clone https://github.com/MissMarzelous/A2-C-sharp-loops.git

# Navigate into the project folder
cd A2-C-sharp-loops

# Run the application
dotnet run
```

> **Note:** Because there are three files each with their own `Main` method,
> only one can be set as the active entry point at a time. To switch between
> programs, open `A2-C-sharp-loops.csproj` and update the startup file, or
> simply comment out the `Main` methods in the files you are not running.

---

## 📸 Screenshots

### Program1 — If-Else Calculator

![If-Else Calculator](A2-Program1-If-Else.png)

### Program2 — Switch Calculator

![Switch Calculator](A2-Program2-Switch.png)

### Program3 — Loop Examples

![Loop Examples](A3-Program3-LoopExamples.png)

---

## 👩‍💻 Author

**MissMarzelous** — C# .NET Core student project
