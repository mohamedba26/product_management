namespace chaabene.Models
{
    public class OfferDetail
    {
        public int Id { get; set; }
        public float price { get; set; }
        public float quantity { get; set; }
        public int productId { get; set; }
        public Product product { get; set; }
        public override string ToString()
        {
            return $"{Id} -price: {price} -quantity: {quantity} -product: {product.Name}";
        }
    }
}
