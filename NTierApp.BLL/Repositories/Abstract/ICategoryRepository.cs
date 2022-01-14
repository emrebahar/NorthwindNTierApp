using NTierApp.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        List<CategoryDTO> GetAllCategoryDTO();
    }
}
