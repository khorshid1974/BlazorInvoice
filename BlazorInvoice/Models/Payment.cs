namespace BlazorInvoice.Models
{
    public enum Currency
    {
        USD,
        DINAR
    }
    public class Payment
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public Currency Currency { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public bool Paid { get; set; }
        public int InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }
    }
}
