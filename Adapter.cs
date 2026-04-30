using System;

// Спільний інтерфейс (стандарт)
public interface ISocialMedia
{
    void SendPost(string message);
}

// Сторонній клас Facebook (у нього свої назви методів, які нам незручні)
public class FacebookApi
{
    public void PostToWall(string msg) 
    {
        Console.WriteLine($"[Facebook API]: Повідомлення '{msg}' викладено на стіну.");
    }
}

// Наш Адаптер — він "перекладає" SendPost у PostToWall
public class FacebookAdapter : ISocialMedia
{
    private FacebookApi _facebook = new FacebookApi();

    public void SendPost(string message)
    {
        _facebook.PostToWall(message);
    }
}
//Коментар для зміни