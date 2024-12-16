using System;

namespace ClassLibrary1.SolidPrincipals.OCP
{
    // Abstract base class representing a generic payment method.
    public abstract class MyPayment
    {
        // Abstract property for the username.
        public abstract string UserName { get; set; }

        // Abstract method for processing payment.
        public abstract string PaymentMethod(double amount);
    }

    // Concrete implementation of MyPayment for PhonePay.
    public class PhonePayClass : MyPayment
    {
        // property to store the user name.
        public override string UserName { get; set; }

        /// <summary>
        /// Implementation of the payment method for PhonePay.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override string PaymentMethod(double amount)
        {
            return $"User name {UserName} Phonepay amout  {amount}";

        }
    }

    // Concrete implementation of MyPayment for Google Pay.
    public class GoolepayPayment : MyPayment
    {
        // Property to store the user name.
        public override string UserName { get; set; }

        /// <summary>
        /// Implementation of the payment method for Google Pay.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override string PaymentMethod(double amount)
        {
            return $"User name {UserName} Phonepay amout  {amount}";
        }
    }
}
