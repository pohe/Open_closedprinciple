using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_closedprinciple
{
    public static class OCP2NotCorrect
    {
        // I denne implementation er PaymentProcessor klassen ikke
        // åben for udvidelse, da hvis vi ønsker at tilføje en ny
        // betalingsmetode, f.eks.MobilePay, skal vi ændre
        // PaymentProcessor klassen.
        // Dette bryder med Open/Closed-princippet.


        // Class that handles payment processing
        public class PaymentProcessor
        {
            // Method to process payment with credit card
            public void ProcessCreditCardPayment(double amount)
            {
                Console.WriteLine($"Processing credit card payment for amount: {amount}");
                // Logic for processing credit card payment
            }

            // Method to process payment with PayPal
            public void ProcessPayPalPayment(double amount)
            {
                Console.WriteLine($"Processing PayPal payment for amount: {amount}");
                // Logic for processing PayPal payment
            }
        }

        public static void Run()
        {
                PaymentProcessor paymentProcessor = new PaymentProcessor();

                // Process payment with credit card
                paymentProcessor.ProcessCreditCardPayment(100.00);

                // Process payment with PayPal
                paymentProcessor.ProcessPayPalPayment(50.00);
        }


    }
}
