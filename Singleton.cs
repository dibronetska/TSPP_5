using System;

public class DatabaseConnection
{
    private static DatabaseConnection _instance;
    private static readonly object _lock = new object();

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
