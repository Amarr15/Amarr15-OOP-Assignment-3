# Part 01 — answers

---

## ShippingCostCalculator

* What was the problem?

The `ShippingCostCalculator` used a `switch` statement based on the carrier name. Adding a new carrier required modifying the existing `ShippingCostCalculator` class, which made the code harder to extend and violated the Open/Closed Principle.

* What did you change?

Introduced the `IShippingCarrier` interface and moved the shipping cost calculation into separate carrier classes such as `AramexShipping`, `FedExShipping`, and `DHLShipping`. The calculator now depends on `IShippingCarrier` instead of knowing specific carriers.

---

## OrderProcessor

* What was the problem?

`OrderProcessor` directly created `SqlOrderRepository` and `SmtpEmailSender` using `new`. This created tight coupling between `OrderProcessor` and the concrete implementations.

* What did you change?

Introduced `IOrderRepository` and `IEmailSender` abstractions and used constructor dependency injection. `OrderProcessor` now receives its dependencies from outside instead of creating them itself.

---

## Notifications

* What was the problem?

The original notification system used inheritance for every combination of channel and behavior, such as `UrgentEmailNotification` and `UrgentScheduledEmailNotification`. This could lead to many classes as more channels and behaviors were added.

* What did you change?

Replaced the inheritance-heavy design with composition. `INotificationChannel` represents the notification channel, while `UrgentNotification` and `ScheduledNotification` represent independent behaviors. These objects can be composed together without creating a separate class for every combination.

---

## Proof

* New carrier file(s):

No new file. Added the `DHLShipping` class to the existing source file.

* New notification channel file(s):

No new file. Added the `WhatsAppChannel` class to the existing notification source file.

* Existing classes left unchanged? (yes/no):

Yes
