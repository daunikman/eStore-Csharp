using System;
using System.Collections.Generic;


namespace Estore.models
{
    public class Customer: User
    {
        public List<BillingInformation> BillingInformation { get; set; }
    }
}