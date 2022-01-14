using NTierApp.BLL.Repositories.Abstract;
using NTierApp.Entities.DTO;
using NTierApp.Entities.Model;
using System.Collections.Generic;
using System.Linq;

namespace NTierApp.BLL.Repositories.Concrete
{
    public class ProductRepository : BaseRepository<Products>, IProductRepository
    {
        DataContext db = new DataContext();
        public List<ProductDTO> GetByIdAllProduct(int id)
        {
            return db.Products.Select(x => new ProductDTO()
            {
                CategoryId = x.CategoryID,
                CategoryName = x.Categories.CategoryName,
                ProductId = x.ProductID,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock
            }).Where(I => I.CategoryId == id).ToList();
        }
    }
}
