namespace BlazorInvoice.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string? CustomerName { get; set; }
        public Currency Currency { get; set; }
        public int Payment { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
    }
}
