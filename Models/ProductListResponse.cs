namespace scannermaui.Models
{
    public class ProductListResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public List<Product> Data { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}