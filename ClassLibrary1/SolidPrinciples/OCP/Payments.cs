using System;

namespace ClassLibrary1.SolidPrincipals.OCP
{

    public abstract class MyPayment
    {
        public abstract string UserName { get; set; }
        public abstract string PaymentMethod(double amount);
    }

    public class PhonePayClass : MyPayment
    {
        public override string UserName { get; set; }
        public override string PaymentMethod(double amount)
        {
            return $"User name {UserName} Phonepay amout  {amount}";

        }
    }

    public class GoolepayPayment : MyPayment
    {
        public override string UserName { get; set; }
        public override string PaymentMethod(double amount)
        {
            return $"User name {UserName} Phonepay amout  {amount}";
        }
    }
}
