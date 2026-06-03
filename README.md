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

**Program1 & Program2 (calculator programs):**
