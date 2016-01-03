using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Payment.Stripe.Data
{
    public partial class StripeCustomerReference : Repository.Pattern.Ef6.Entity
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string StripeCustomerID { get; set; }
    }
}
