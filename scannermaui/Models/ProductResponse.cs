namespace scannermaui.Models
{
    public class ProductResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public ProductData Data { get; set; }
    }

    public class ProductData
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}