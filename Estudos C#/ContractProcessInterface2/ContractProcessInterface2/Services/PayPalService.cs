using System.Reflection.Metadata.Ecma335;

namespace ContractProcessInterface2.Services
{
    internal class PayPalService
    {
        public const double SimpleFee = 0.01;
        public const double PaymentTaxFee = 0.02;


        public double PaymentFee (double amount)
        {
            return amount * SimpleFee;
        }
    }
}
