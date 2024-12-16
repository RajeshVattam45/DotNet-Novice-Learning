using System;

namespace ClassLibrary1.SolidPrinciples.DIP
{
    // Abstraction.
    public interface IPaymentMethod
    {
        public void ProcessPayment(decimal amount);
    }

    // Low-level module 1.
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment of {amount:C} made using Credit Card.");
        }
    }

    // Low-level module 2.
    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment of {amount:C} made using PayPal.");
        }
    }

    // High-level module.
    public class PaymentProcessor
    {
        public readonly IPaymentMethod _paymentMethod;

        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void MakePayment(decimal amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }

    public class CreateObject
    {
        public void CreateObjectMethod()
        {
            // Use Credit Card for payment
            IPaymentMethod creditCard = new CreditCardPayment();
            PaymentProcessor processor1 = new PaymentProcessor(creditCard);
            processor1.MakePayment(100.00m);

            // Use PayPal for payment
            IPaymentMethod payPal = new PayPalPayment();
            PaymentProcessor processor2 = new PaymentProcessor(payPal);
            processor2.MakePayment(200.00m);
        }
    }
}
