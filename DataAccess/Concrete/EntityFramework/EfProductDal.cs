using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, CafeContext>, IProductDal
    {
        public ProductDetailDto GetProductDetailById(Expression<Func<Product, bool>> filter)
        {
            using (CafeContext context = new CafeContext())
            {
                var result = from p in filter is null ? context.Products : context.Products.Where(filter)
                             join c in context.Category on p.CategoryId equals c.Id
                             select new ProductDetailDto { Id = p.Id, CategoryName = c.Name, Description = p.Description, Name = p.Name, ImageUrl = p.ImageUrl, Price = p.Price };
                return result.FirstOrDefault();
            }
        }

        public List<ProductDetailDto> GetProductDetails(Expression<Func<Product, bool>> filter = null)
        {
            using (CafeContext context = new CafeContext())
            {
                var result = from p in filter is null ? context.Products : context.Products.Where(filter)
                             join c in context.Category on p.CategoryId equals c.Id
                             select new ProductDetailDto { Id = p.Id, CategoryName = c.Name, Description = p.Description, Name = p.Name, ImageUrl = p.ImageUrl, Price = p.Price  };
                return result.ToList();
            }
        }
    }
}
