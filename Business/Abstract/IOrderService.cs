using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> GetById(int id);
        IDataResult<List<OrderDetailDto>> GetOrderDetails();
        IDataResult<List<OrderDetailDto>> GetOrderDetailByUserId(int userId);
        IResult Insert(Order order);
        IResult Update(Order order);
        IResult Delete(Order order);
    }
}
