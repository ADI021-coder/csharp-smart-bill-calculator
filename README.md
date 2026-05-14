# Smart Bill Calculator (C#)

A C# console-based billing application that calculates subtotal, tax, and final bill amount using conditional business rules and input validation.

---

## Features

- Calculates subtotal using quantity and item price
- Applies tax percentage to the subtotal
- Adds surcharge based on business conditions
- Handles invalid user input using `TryParse`
- Prevents negative or zero values
- Allows repeated calculations using loop-based flow

---

## Business Rules

### Surcharge Rule

A surcharge of ₹100 is added when:

- Subtotal is greater than or equal to ₹2000
- AND tax percentage is greater than or equal to 18%

Otherwise, no surcharge is applied.

---

## Concepts Used

- Variables and data types
- Arithmetic operations
- Conditional statements (`if-else`)
- Logical operators (`&&`)
- Loops (`do-while`)
- Input validation using `TryParse`
- Business rule implementation
- String interpolation
- Console input/output
- Basic exception handling concepts

---

## Validation Logic

The application validates:

- Quantity must be a positive integer
- Item price must be greater than 0
- Tax percentage must be greater than 0
- Invalid inputs restart the calculation safely

---

## Example Output

```text
enter quantity: 5
enter item price: 450
enter tax percentage: 18

Surcharge of Rs 100/- is added to your purchase

your final is 2250, and your tax is 405, and your final price is 2755

---

## Why This Project?

This project was built to practice real-world programming fundamentals using C# console applications.
Instead of creating a project from scratch repeatedly, this application was improved incrementally by adding:

-Validation logic
-Safer user input handling
-Conditional business rules
-Better program flow

The goal was to simulate how real software evolves over time through refactoring and feature improvements.

---

## Possible future enhancements:
-Discount system
-Methods and class-based structure (OOP)
-Database integration using SQL
-Entity Framework integration
-Bill history storage
-File handling
-ASP.NET or Razor frontend integration

---

## Tech Used
-C#
-.NET Console Application
-VS Code
-Git & GitHub
