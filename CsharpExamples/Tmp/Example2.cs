namespace CsharpApplication
{
    public class PaymentData2
    {
        public decimal Amount { get; set; }
        public string Method { get; set; }
        public int CardNumber { get; set; }
        public int ExpiryYear { get; set; }
        public int ExpiryMonth { get; set; }
        public int Code { get; set; }
        public string InvoiceId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}