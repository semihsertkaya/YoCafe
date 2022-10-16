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
    public class EfOrderDal : EfEntityRepositoryBase<Order, CafeContext>, IOrderDal
    {
        public List<OrderDetailDto> GetOrderDetails(Expression<Func<Order, bool>> filter = null)
        {
            using (CafeContext context = new CafeContext())
            {
                var result = from o in filter is null ? context.Orders : context.Orders.Where(filter)
                             join p in context.Products on o.ProductId equals p.Id
                             join u in context.Users on o.UserId equals u.Id
                             select new OrderDetailDto { Id = o.Id, ProductName = p.Name, UserName = u.FirstName + "  " + u.LastName, Description = p.Description, ImageUrl = p.ImageUrl, Price = p.Price };
                return result.ToList();
            }
        }
    }
}
