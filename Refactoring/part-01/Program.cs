using RefactoringLab;

var shipping = new ShippingCostCalculator();

var aramex = new AramexShipping();
var fedEx = new FedExShipping();

Console.WriteLine($"Aramex 2kg → {shipping.Calculate(aramex, 2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate(fedEx, 2)}");
Console.WriteLine();

var repo = new SqlOrderRepository();
var email = new SmtpEmailSender();
var processor = new OrderProcessor(repo, email);
processor.Process(1001, "customer@example.com");
Console.WriteLine();

var emailNotification = new Notification(
    new EmailChannel(),
    new UrgentNotification(),
    new ScheduledNotification(DateTime.Today.AddHours(18)));

emailNotification.Send(
    "customer@example.com",
    "Your order ships tomorrow");


var smsNotification = new Notification(
    new SmsChannel(),
    new UrgentNotification());

smsNotification.Send(
    "+201000000000",
    "OTP 4821");

var whatsapp = new Notification(
    new WhatsAppChannel(),
    new UrgentNotification(),
    new ScheduledNotification(DateTime.Today.AddHours(19)));

whatsapp.Send(
    "+201000000000",
    "Your order is ready");