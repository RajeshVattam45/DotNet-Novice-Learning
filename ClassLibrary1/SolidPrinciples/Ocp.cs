using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.OpenClosedPrinciple
{
    // Open-closed Principle (OCP).
    public interface IPayment
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Credit card payment " + amount);
        }
    }

    public class PaypalPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Paypal Payment " + amount);
        }
    }

    public class UpiPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Phonepay Payment amout" + amount);
        }
    }

    public class PaymentProcessor
    {
        private readonly IPayment _paymentMethod;

        public PaymentProcessor(IPayment paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void Process(decimal amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }

    // For tesing add new functionality.
    public class CryptoPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Crypto Payment of {amount}");
        }
    }


    public class CreatePaymentObject
    {
        public static void ProcessPayments()
        {
            // Create a CreditCardPayment object and process a payment
            IPayment creditCardPayment = new CreditCardPayment();
            PaymentProcessor creditCardProcessor = new PaymentProcessor(creditCardPayment);
            creditCardProcessor.Process(200);

            // Create a PayPalPayment object and process a payment
            IPayment payPalPayment = new PaypalPayment();
            PaymentProcessor payPalProcessor = new PaymentProcessor(payPalPayment);
            payPalProcessor.Process(300);

            // Create a UpiPayment object and process a payment
            IPayment upiPayment = new UpiPayment();
            PaymentProcessor upiProcessor = new PaymentProcessor(upiPayment);
            upiProcessor.Process(400);

            // Add new functionality (Crypto Payment)
            IPayment cryptoPayment = new CryptoPayment();
            PaymentProcessor processor4 = new PaymentProcessor(cryptoPayment);
            processor4.Process(500);
        }

    }

}
