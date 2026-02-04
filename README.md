# csharp-smart-bill-calculator
A C# console-based billing system with tax calculation and conditional surcharge rules.
# Smart Bill Calculator (C#)

This project is an extension of a basic bill calculator that applies conditional business rules.

## Features
- Calculates subtotal using quantity and unit price
- Applies tax percentage
- Adds a surcharge based on predefined conditions

## Rule Logic
- If subtotal ≥ 2000 AND tax percentage ≥ 18  
  → Add ₹100 surcharge  
- Otherwise  
  → No surcharge applied

## Concepts Used
- Arithmetic operations
- Logical operators (`&&`, `||`)
- Conditional statements
- Incremental enhancement of existing code

## Why this project?
This project simulates how real billing systems evolve by adding new rules over time.
It focuses on applying logic to an already working system instead of rewriting everything.

## Example Output
Surcharge of Rs 100/- is added to your purchase
Final Price: 2359.97


## Notes
- Built without external help
- Demonstrates rule-based thinking
- Can be further extended with discounts or slabs
