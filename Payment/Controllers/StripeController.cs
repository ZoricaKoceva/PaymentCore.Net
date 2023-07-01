using Microsoft.AspNetCore.Mvc;
using Payment.Contracts;
using Payment.Models.Stripe;

namespace Payment.Controllers
{
    [Route("api/[controller]")]
    public class StripeController : Controller
    {
        private readonly IStripeAppService _stripeService;

        public StripeController(IStripeAppService stripeService)
        {
            _stripeService = stripeService;
        }

        [HttpPost("customer/Add")]
        public async Task<ActionResult<StripeCustomer>> AddStripeCustomer([FromBody] AddStripeCustomer customer, CancellationToken cancellationToken)
        {
            StripeCustomer createdStripeCustomer = await _stripeService.AddStripeCustomerAsync(customer, cancellationToken);
        
            return Ok(createdStripeCustomer);
        }

        [HttpPost("Payment/Add")]
        public async Task<ActionResult<StripePayment>> AddStripePayment([FromBody] AddStripePayment payment, CancellationToken cancellationToken)
        {
            StripePayment createdPayment = await _stripeService.AddStripePaymentAsync(payment, cancellationToken);

            return Ok(createdPayment);
        }

    }
}
