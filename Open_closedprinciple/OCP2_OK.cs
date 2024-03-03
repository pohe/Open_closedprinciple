using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_closedprinciple
{
    public  class OCP2_OK
    {
        //I dette eksempel er PaymentProcessor klassen åben for
        //udvidelse(Open for Extension), da du kan tilføje nye
        //betalingsmetoder ved blot at oprette nye klasser,
        //der implementerer IPaymentMethod grænsefladen.
        //Samtidig er PaymentProcessor klassen lukket for modifikation
        //(Closed for Modification), da du ikke behøver at ændre selve
        //PaymentProcessor klassen for at tilføje nye betalingsmetoder.
        //Dette opfylder Open/Closed-princippet i SOLID-principperne.
        public interface IPaymentMethod
        {
            void ProcessPayment(double amount);
        }

        // Concrete implementation of payment method: Credit Card
        public class CreditCardPayment : IPaymentMethod
        {
            public void ProcessPayment(double amount)
            {
                Console.WriteLine($"Processing credit card payment for amount: {amount}");
                // Logic for processing credit card payment
            }
        }

        // Concrete implementation of payment method: PayPal
        public class PayPalPayment : IPaymentMethod
        {
            public void ProcessPayment(double amount)
            {
                Console.WriteLine($"Processing PayPal payment for amount: {amount}");
                // Logic for processing PayPal payment
            }
        }

        // Class that uses payment methods
        public class PaymentProcessor
        {
            private IPaymentMethod _paymentMethod;

            // Constructor that accepts payment method
            public PaymentProcessor(IPaymentMethod paymentMethod)
            {
                _paymentMethod = paymentMethod;
            }

            // Method to process payment
            public void ProcessPayment(double amount)
            {
                _paymentMethod.ProcessPayment(amount);
            }
        }

        public static void Run()
        {
            // Using the PaymentProcessor with CreditCardPayment
            PaymentProcessor creditCardPaymentProcessor = new PaymentProcessor(new CreditCardPayment());
           creditCardPaymentProcessor.ProcessPayment(100.00);

           // Using the PaymentProcessor with PayPalPayment
           PaymentProcessor payPalPaymentProcessor = new PaymentProcessor(new PayPalPayment());
           payPalPaymentProcessor.ProcessPayment(50.00);
        }
    }
}
