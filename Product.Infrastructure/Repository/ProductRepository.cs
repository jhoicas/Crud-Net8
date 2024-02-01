using Product.Core.Entities;
using Product.Core.Interface;
using Product.Core.Services;

namespace Product.Infrastructure.Repository
{
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
