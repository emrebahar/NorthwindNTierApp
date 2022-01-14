using NTierApp.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL.Repositories.Abstract
{
    public interface IProductRepository
    {
        List<ProductDTO> GetByIdAllProduct(int id);
    }
}
