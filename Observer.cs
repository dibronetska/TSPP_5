using System;
using System.Collections.Generic;

// Інтерфейс підписника
public interface IObserver
{
    void Update(double price);
}

// Клас користувача (Спостерігач)
public class Investor : IObserver
{
    private string _name;
    public Investor(string name) => _name = name;

    public void Update(double price)
    {
        Console.WriteLine($"[Сповіщення для {_name}]: Ціна акції змінилася на {price} USD");
    }
}

// Клас біржі (Суб'єкт)
public class StockExchange
{
    private List<IObserver> _investors = new List<IObserver>();

    public void Subscribe(IObserver investor) => _investors.Add(investor);

    public void ChangePrice(double newPrice)
    {
        foreach (var investor in _investors)
        {
            investor.Update(newPrice);
        }
    }
}