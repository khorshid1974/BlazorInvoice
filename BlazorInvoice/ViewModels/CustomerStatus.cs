using BlazorInvoice.Models;

namespace BlazorInvoice.ViewModels
{
    public class CustomerStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int InvoiceId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal InvoiceAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public Currency Currency { get; set; }
        public int PaymentAmount { get; set; }
        public bool Paid { get; set; }
    }
}
