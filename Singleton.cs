using System;

public class DatabaseConnection
{
    private static DatabaseConnection _instance;
    // Об'єкт для блокування (щоб два потоки не створили два об'єкти одночасно)
    private static readonly object _lock = new object();

    // Приватний конструктор — головна фішка! Ніхто не зможе написати "new DatabaseConnection()"
    private DatabaseConnection() 
    {
        Console.WriteLine("[System: Встановлено з'єднання з базою даних.");
    }

    public static DatabaseConnection? Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new DatabaseConnection();
                }
                return _instance;
            }
        }
    }

    public void Execute(string query)
    {
        Console.WriteLine($"[DB]: Виконується запит: {query}");
    }
}