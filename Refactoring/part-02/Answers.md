# Part 02 — answers

---

## Reports

* What was the problem?

The three report exporters repeated the same export workflow: loading the data, validating it, formatting it, and saving the result. Only the formatting step was different between CSV, JSON, and Text.

* What did you change?

Introduced the `ReportExporter` abstract class using the Template Method pattern. The `Export()` method now defines the common export workflow once, while `Load()`, `Validate()`, and `Save()` are shared implementations. The `Format()` method is abstract so each exporter can provide its own formatting logic.

* Why did you choose that approach?

An abstract class was chosen because the exporters share both behavior and a fixed algorithm structure. The common implementation can be placed in the base class, while subclasses override only the part that differs. This avoids code duplication and keeps the export process consistent.


---

## Enrollment

* What was the problem?

`Program` was directly coordinating four different services: `PaymentGateway`, `SeatInventory`, `InvoiceGenerator`, and `EmailService`. This exposed the enrollment workflow and its implementation details to the caller.

* What did you change?

Introduced an `EnrollmentFacade` that coordinates the four existing services through a single `Enroll` method. The existing services were left unchanged.

* Why did you choose that approach?

The Facade provides a simple entry point for the enrollment process and hides the coordination between the underlying services. This reduces the complexity that the caller needs to know and keeps the enrollment workflow in one place.

