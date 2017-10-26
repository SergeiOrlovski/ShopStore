namespace ShopStore.Repository.DbContext
{
    using System.ComponentModel.DataAnnotations;

    public partial class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string Description { get; set; }

        public int Shop_ID { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
