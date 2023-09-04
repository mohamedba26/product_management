using chaabene.Models;

namespace chaabene.Service.Product_Service
{
    public interface IProductService
    {
        bool AddUpdateProduct(Product product);
        bool DeleteProduct(int id);
        Product GetProductById(int id);
        List<Product> GetAllProducts();
    }
}
