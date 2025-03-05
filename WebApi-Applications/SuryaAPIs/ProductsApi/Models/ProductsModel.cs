namespace ProductsApi.Models
{
    public class ProductModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string image { get; set; }
        public ProductRating rating { get; set; }
    }
}
