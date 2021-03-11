namespace CsharpApplication
{
    public class PymentData3
    {
        public decimal Amount { get; set; }
        public Method3 Method { get; set; }
        public CardDetails3 CardDetails { get; set; }
        public InvoiceDetails3 InvoiceDetails { get; set; }
    }

    public enum Method3
    {
        Card, Invoice
    }

    public class CardDetails3
    {
        public int CardNumber { get; set; }
        public int ExpiryYear { get; set; }
        public int ExpiryMonth { get; set; }
        public int Code { get; set; }
    }

    public class InvoiceDetails3
    {
        public string InvoiceId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}