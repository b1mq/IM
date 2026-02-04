namespace IM.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal OriginalPrice { get; set; }
        public bool isAviable { get; set; }
        public long  SKU {  get; set; } // Артикул
        public decimal TotalPrice { get; set; }
        public string Category { get; set; }
        public ICollection<BasketItem> BasketItems { get; set; }
        public int? Discount { get; set; }
    }
}
