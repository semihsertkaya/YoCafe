using Business.Abstract;
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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.productDeleted);
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll());
        }

        public IDataResult<Product> GetById(int Id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p=>p.Id == Id));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetailByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(p=>p.CategoryId == categoryId));
        }

        public IDataResult<ProductDetailDto> GetProductDetailById(int Id)
        {
            return new SuccessDataResult<ProductDetailDto>(_productDal.GetProductDetailById(p=> p.Id == Id));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        public IResult Insert(Product product)
        {
            _productDal.Insert(product);
            return new SuccessResult(Messages.productAdded);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.productUpdated);
        }
    }
}
