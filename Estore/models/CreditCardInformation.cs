namespace Estore.models
{
    public class CreditCardInformation
    {
        public string CreditCardNumber { get; set; }
        public string NameOnCard { get; set; }
        public byte CardCvv { get; set; }
        public MonthYear CardExpirationYearMonth { get; set; }
        public CardType CardType { get; set; }

     
    }
}