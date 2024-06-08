using BlazorInvoice.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorInvoice.Data
{
    public class InvoiceDbContext : DbContext
    {
        public InvoiceDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<BlazorInvoice.Models.Customer> Customer { get; set; } = default!;
        public DbSet<Payment> Payments { get; set; }
      

    }
}
