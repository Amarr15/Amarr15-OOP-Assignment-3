namespace RefactoringLab;

public interface INotificationChannel
{
    void Send(string to, string message, DateTime? sendAt = null);
}

public class EmailChannel : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt = null)
    {
        if (sendAt.HasValue)
        {
            Console.WriteLine(
                $"[email scheduled {sendAt:g}] {to}: {message}");
        }
        else
        {
            Console.WriteLine(
                $"[email] {to}: {message}");
        }
    }
}

public class SmsChannel : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt = null)
    {
        if (sendAt.HasValue)
        {
            Console.WriteLine(
                $"[sms scheduled {sendAt:g}] {to}: {message}");
        }
        else
        {
            Console.WriteLine(
                $"[sms] {to}: {message}");
        }
    }
}

public class WhatsAppChannel : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt = null)
    {
        if (sendAt.HasValue)
        {
            Console.WriteLine(
                $"[whatsapp scheduled {sendAt:g}] {to}: {message}");
        }
        else
        {
            Console.WriteLine(
                $"[whatsapp] {to}: {message}");
        }
    }
}

public class UrgentNotification
{
    public string FormatMessage(string message)
    {
        return $"[URGENT] {message}";
    }
}

public class ScheduledNotification
{
    public DateTime SendAt { get; }

    public ScheduledNotification(DateTime sendAt)
    {
        SendAt = sendAt;
    }
}

public class Notification
{
    private readonly INotificationChannel _channel;
    private readonly UrgentNotification? _urgent;
    private readonly ScheduledNotification? _scheduled;

    public Notification(
        INotificationChannel channel,
        UrgentNotification? urgent = null,
        ScheduledNotification? scheduled = null)
    {
        _channel = channel;
        _urgent = urgent;
        _scheduled = scheduled;
    }

    public void Send(string to, string message)
    {
        if (_urgent != null)
        {
            message = _urgent.FormatMessage(message);
        }

        DateTime? sendAt = _scheduled?.SendAt;

        _channel.Send(to, message, sendAt);
    }
}