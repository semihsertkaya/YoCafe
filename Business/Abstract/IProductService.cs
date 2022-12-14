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
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<List<ProductDetailDto>> GetProductDetailByCategoryId(int categoryId);
        IDataResult<ProductDetailDto> GetProductDetailById(int Id);
        IDataResult<Product> GetById(int Id);
        IResult Insert(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }
}
