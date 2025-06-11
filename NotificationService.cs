using System.Runtime.CompilerServices;

namespace LibraryManagement;

public delegate void NotificationHandler(string message);
public class NotificationService
{
    public event  NotificationHandler OnNotify;
    public  void SendEmailNotification( string message)
    {
        Console.WriteLine($"Email sent to: {message}");
    }

    public  void SendsmslNotification(string message,string phnumber)
    {
        Console.WriteLine($"sending {phnumber}as {message}");
    }
    public void Notify(string message)
    {
        OnNotify?.Invoke(message);
    }

}