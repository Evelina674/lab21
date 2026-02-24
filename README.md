# Lab21 — Strategy Pattern + Factory Method (Variant 7: Cloud Storage)

## 📌 Overview

This project demonstrates the use of the **Strategy Pattern**, **Factory Method Pattern**, and the **Open/Closed Principle (OCP)** in C#.

The application calculates service costs for a **Cloud Storage system (Variant 7)** using different pricing strategies.

Language: C#  
Platform: .NET  
Project type: Console Application  

---

## 🎯 Goal

The goal of this lab is to learn how to:

- Implement the Strategy Pattern
- Implement the Factory Method Pattern
- Apply the Open/Closed Principle (OCP)
- Build a flexible and extensible system

---

## 🧠 Strategy Pattern

The Strategy Pattern allows defining different algorithms and selecting them at runtime.

Interface:

```
ICloudPlanStrategy
```

Implementations:

- PersonalPlan
- BusinessPlan
- EnterprisePlan

Each plan calculates the monthly cost using its own logic.

---

## 🏭 Factory Method Pattern

Factory Method is used to create the appropriate strategy object.

Class:

```
CloudPlanFactory
```

Method:

```
CreatePlan(string planType)
```

This allows creating objects without specifying the exact class in the main program.

---

## ⚙ Service Layer

Class:

```
CloudStorageService
```

This class calculates the cost using the selected strategy.

It depends only on the interface, not on concrete implementations.

---

## 🧩 Open/Closed Principle (OCP)

The system follows OCP:

- Open for extension (new plans can be added)
- Closed for modification (existing code does not need to change)

---

## 📁 Project Structure

```
lab21
│
├── CloudStorage
│   ├── Plans
│   │   ├── ICloudPlanStrategy.cs
│   │   ├── PersonalPlan.cs
│   │   ├── BusinessPlan.cs
│   │   └── EnterprisePlan.cs
│   │
│   └── Services
│       ├── CloudPlanFactory.cs
│       └── CloudStorageService.cs
│
├── Shipping
│
└── Program.cs
```

---

## ▶ Example Run

```
Choose system:
2 - Cloud Storage

Enter plan: business
Enter storage (GB): 100
Enter users: 5

Monthly cost: 40
```

---

## ✅ Features

- Strategy Pattern implementation
- Factory Method Pattern implementation
- Open/Closed Principle compliance
- Clean architecture
- Easy to extend
- Console interface

---

## 👩‍💻 Author

GitHub Repository:  
https://github.com/Evelina674/lab21

---

## 📌 Conclusion

This lab successfully demonstrates how to use Strategy and Factory Method patterns in a real-world scenario.  
The system is flexible, maintainable, and follows SOLID principles.
