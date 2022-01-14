
using NTierApp.BLL.Repositories.Abstract;
using NTierApp.Entities.DTO;
using NTierApp.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL.Repositories.Concrete
{
    public class CategoryRepository : BaseRepository<Categories>, ICategoryRepository
    {
        DataContext db = new DataContext();
        public List<CategoryDTO> GetAllCategoryDTO()
        {
            return db.Categories.Select(x => new CategoryDTO
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName
            }).ToList();
        }
    }
}
