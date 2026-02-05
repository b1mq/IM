namespace IM.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal OriginalPrice { get; set; }
        public bool isAviable { get; set; }
        public long  SKU {  get; set; } 
        public decimal TotalPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<BasketItem> BasketItems { get; set; } = new List<BasketItem>();
        public int? Discount { get; set; }
    }

}
