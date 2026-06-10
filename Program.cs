using System;
using System.Collections.Generic;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Практична робота №2. Узагальнені класи");
Console.WriteLine();

Console.WriteLine("Завдання 1. SequenceBuilder<T>");
SequenceBuilder<int> numbers = new();
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.PrintAll();

SequenceBuilder<string> words = new();
words.Add("C#");
words.Add("Generics");
words.Add("Практика");
words.PrintAll();

Console.WriteLine();
Console.WriteLine("Завдання 2. ChangeTracker<T>");
ChangeTracker<int> intTracker = new();
intTracker.LogValue(5);
intTracker.LogValue(12);

ChangeTracker<double> doubleTracker = new();
doubleTracker.LogValue(2.5);
doubleTracker.LogValue(7.75);

ChangeTracker<string> stringTracker = new();
stringTracker.LogValue("Початок");
stringTracker.LogValue("Оновлено");

class SequenceBuilder<T>
{
    private readonly List<T> items = new();

    public void Add(T item)
    {
        items.Add(item);
    }

    public List<T> GetAll()
    {
        return items;
    }

    public void PrintAll()
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class ChangeTracker<T>
{
    private T? currentValue;
    private bool hasValue;

    public void LogValue(T newValue)
    {
        if (!hasValue)
        {
            Console.WriteLine($"Початкове значення: {newValue}");
            currentValue = newValue;
            hasValue = true;
            return;
        }

        Console.WriteLine($"Було: {currentValue}; стало: {newValue}");
        currentValue = newValue;
    }
}
