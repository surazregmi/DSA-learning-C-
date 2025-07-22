# 📘 DSA in C# – Day 1 Notes

Welcome to Day 1 of my Data Structures and Algorithms (DSA) learning journey using **C#**. This document covers foundational theory and hands-on problems to build a strong base.

---

## 📌 Topics Covered

- ✅ What is DSA?
- ✅ Why do we need DSA?
- ✅ C# Compilation Process
- ✅ Memory Management in C#
- ✅ Arrays: Theory + Code Examples
- ✅ Practice Problems

---

## 📚 What is DSA?

### Data Structures
> Structured ways to store and organize data for efficient operations.

| Structure     | Description                      | Example Use Case         |
|---------------|----------------------------------|--------------------------|
| Array         | Sequential memory storage        | Storing scores           |
| Stack         | LIFO                             | Undo operations          |
| Queue         | FIFO                             | Job scheduling           |
| Hash Table    | Key-value mapping                | Caching, dictionaries    |
| Tree          | Hierarchical structure           | Folder structure         |
| Graph         | Nodes and edges                  | Social networks, maps    |

### Algorithms
> Step-by-step instructions to solve problems

Common types:
- Searching, Sorting
- Recursion
- Backtracking
- Dynamic Programming

---

## 🤔 Why Do We Need DSA?

- Efficient problem-solving
- Reduce time & space complexity
- Improve scalability and performance
- Essential for coding interviews
- Helps in real-world architecture and optimization

---

## ⚙️ How C# Code is Compiled

1. **C# Source Code (.cs)**  
   ↓  
2. **Compiled to IL (Intermediate Language)**  
   ↓  
3. **JIT (Just-In-Time) Compiler → Native Code**  
   ↓  
4. **CLR Executes the Code**

**Tools Involved:**
- `csc.exe`: C# Compiler
- CLR: Common Language Runtime
- JIT: Converts IL to machine code at runtime

---

## 🧠 Memory Management in C#

| Memory Area | Stores               | Example                        |
|-------------|----------------------|--------------------------------|
| Stack       | Value types          | `int x = 5`                    |
| Heap        | Reference types      | `int[] arr = new int[5]`      |

- **Garbage Collector (GC)**: Automatically frees memory of unused objects
- **Managed Memory**: Developers don’t manually allocate/deallocate memory

---

## 🔢 Arrays in C#

### ✅ What is an Array?
- Fixed-size collection of same-type elements
- Stored in contiguous memory blocks
- Index-based access → O(1) time complexity

### 🧾 Syntax

```csharp
int[] arr = new int[5]; // Declares an array of 5 integers
int[] primes = { 2, 3, 5, 7 }; // Inline initialization
