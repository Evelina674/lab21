# Lab21 — Strategy Pattern + Factory Method (Variant 7: Cloud Storage)

## Опис

Ця лабораторна робота демонструє використання патернів проектування:

- Strategy Pattern
- Factory Method Pattern

та принципу

- Open/Closed Principle (OCP)

Мова програмування: C#  
Тип проекту: Console Application  
Платформа: .NET

---

## Завдання

Реалізувати систему розрахунку вартості для Cloud Storage (Варіант 7).

Стратегії:

- PersonalPlan
- BusinessPlan
- EnterprisePlan

Параметри:

- Обсяг даних (GB)
- Кількість користувачів

Кожен план має власний алгоритм розрахунку вартості.

---

## Використані патерни

### Strategy Pattern

Дозволяє змінювати алгоритм розрахунку під час виконання програми.

Інтерфейс:
