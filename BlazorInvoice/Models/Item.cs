using System.ComponentModel.DataAnnotations;

namespace BlazorInvoice.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string ItemName { get; set; }
        [Required, Range(1,1000)]
        public int PurchasePrice { get; set; }
        [Required, Range(1, 10000)]
        public int SalePrice { get; set; }
        public int Quantity { get; set; }
        public int Balance { get; set; }

    }
}
