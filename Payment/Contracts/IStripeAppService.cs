using Payment.Models.Stripe;

namespace Payment.Contracts
{
    public interface IStripeAppService
    {
        Task<StripeCustomer> AddStripeCustomerAsync(AddStripeCustomer customer, CancellationToken cancellationToken);
        Task<StripePayment> AddStripePaymentAsync(AddStripePayment payment, CancellationToken cancellationToken);
    }
}
