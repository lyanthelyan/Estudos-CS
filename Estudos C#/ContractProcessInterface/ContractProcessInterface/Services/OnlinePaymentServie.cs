using ContractProcessInterface.Entities;
namespace ContractProcessInterface.Services
{
    interface OnlinePaymentServie
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);
        
    }
}
