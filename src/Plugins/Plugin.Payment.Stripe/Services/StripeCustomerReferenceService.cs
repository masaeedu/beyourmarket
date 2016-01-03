using Plugin.Payment.Stripe.Data;
using Repository.Pattern.Repositories;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Payment.Services
{
    public interface IStripeCustomerReferenceService : IService<StripeCustomerReference>
    {
    }

    public class StripeCustomerReferenceService : Service<StripeCustomerReference>, IStripeCustomerReferenceService
    {
        public StripeCustomerReferenceService(IRepositoryAsync<StripeCustomerReference> repository)
            : base(repository)
        {
        }
    }
}
