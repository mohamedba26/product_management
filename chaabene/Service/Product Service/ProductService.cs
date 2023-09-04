using chaabene.Models;

namespace chaabene.Service.Product_Service
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;
        public ProductService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool AddUpdateProduct(Product product)
        {
            try
            {
                if (product.Id == 0)
                {
                    _dataContext.Products.Add(product);
                }
                else
                {
                    _dataContext.Products.Update(product);
                }
                _dataContext.SaveChanges();
                return true;
            }
            catch(Exception ex) {
            return false;
            }
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                var product = GetProductById(id);
                if(product==null)
                    return false;
                _dataContext.Products.Remove(product);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Product> GetAllProducts()
        {
            return _dataContext.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _dataContext.Products.Find(id);
        }
    }
}
