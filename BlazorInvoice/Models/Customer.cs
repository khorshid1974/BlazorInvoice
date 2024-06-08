namespace BlazorInvoice.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Invoice> Invoices { get; set; }
        public Customer()
        {
            Invoices = new List<Invoice>();
        }
    }
}
