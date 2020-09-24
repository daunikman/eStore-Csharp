using System;

namespace Estore.models
{
    public class BillingInformation
    {
        public Address DeliveryAddress { get; set; }
        public CreditCardInformation CreditCardInformation { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhoneNumber { get; set; }
    }
}