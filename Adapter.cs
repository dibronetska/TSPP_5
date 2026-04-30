using System;

public interface ISocialMedia
{
    void SendPost(string message);
}

public class FacebookApi
{
    public void PostToWall(string msg) 
    {
        Console.WriteLine($"[Facebook API]: Повідомлення '{msg}' викладено на стіну.");
    }
}

public class FacebookAdapter : ISocialMedia
{
    private FacebookApi _facebook = new FacebookApi();

    public void SendPost(string message)
    {
        _facebook.PostToWall(message);
    }
}
