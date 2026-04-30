using System;

class Program
{
    static void Main()
    {
        // 1. Тест Singleton
        Console.WriteLine("Тест Singleton");
        DatabaseConnection db = DatabaseConnection.Instance;
        db.Execute("SELECT * FROM Users");

        // 2. Тест Adapter
        Console.WriteLine("Тест Adapter");
        ISocialMedia social = new FacebookAdapter();
        social.SendPost("Привіт!");

        // 3. Тест Observer
        Console.WriteLine("Тест Observer");
        StockExchange binance = new StockExchange();
        Investor diana = new Investor("Діана");
        
        binance.Subscribe(diana);
        binance.ChangePrice(68000.50);
    }
}
