using Product.Core.Entities;
using Product.Core.Interface;
using Product.Core.Services;

namespace Product.Infrastructure.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
