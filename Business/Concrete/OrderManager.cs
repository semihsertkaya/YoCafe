﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(Messages.OrderDeleted);
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
        }

        public IDataResult<Order> GetById(int id)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(o=> o.Id == id));
        }

        public IDataResult<List<OrderDetailDto>> GetOrderDetailByUserId(int userId)
        {
            return new SuccessDataResult<List<OrderDetailDto>>(_orderDal.GetOrderDetails(o=> o.UserId == userId));
        }

        public IDataResult<List<OrderDetailDto>> GetOrderDetails()
        {
            return new SuccessDataResult<List<OrderDetailDto>>(_orderDal.GetOrderDetails());
        }

        public IResult Insert(Order order)
        {
            _orderDal.Insert(order);
            return new SuccessResult(Messages.OrderAdded);
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.OrderUpdated);
        }
    }
}
