using Payment.Contracts;
using Payment.Models.Stripe;
using Stripe;

namespace Payment.Application
{
    public class StripeAppService : IStripeAppService
    {
        private readonly ChargeService _chargeService; 
        private readonly CustomerService _customerService;  
        private readonly TokenService _tokenService;

        public StripeAppService(ChargeService chargeService, CustomerService customerService, TokenService tokenService)
        {
            _chargeService = chargeService;
            _customerService = customerService;
            _tokenService = tokenService;
        }

        /// <summary>
        /// Create a new customer at Stripe through API using customer and card details from records.
        /// </summary>
        /// <param name="customer">Stripe Customer</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>Stripe Customer</returns>
        public Task<StripeCustomer> AddStripeCustomerAsync(AddStripeCustomer customer, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add a new payment at Stripe using Customer and Payment details.
        /// Customer has to exist at Stripe already.
        /// </summary>
        /// <param name="payment">Stripe Payment</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns><Stripe Payment/returns>
        public Task<StripePayment> AddStripePaymentAsync(AddStripePayment payment, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
