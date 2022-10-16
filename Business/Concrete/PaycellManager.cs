using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PaycellManager : IPaycellService
    {
        private IPaycellDal _paycellDal;

        public PaycellManager(IPaycellDal paycellDal)
        {
            _paycellDal = paycellDal;
        }

        public IResult Delete(Paycell payCell)
        {
            _paycellDal.Delete(payCell);
            return new SuccessResult(Messages.productDeleted);
        }

        public IDataResult<List<Paycell>> GetAll()
        {
            return new SuccessDataResult<List<Paycell>>(_paycellDal.GetAll());
        }

        public IDataResult<Paycell> GetById(string transactionId)
        {
            return new SuccessDataResult<Paycell>(_paycellDal.Get(p => p.transactionId == transactionId));
        }

        public IResult Insert(Paycell payCell)
        {
            _paycellDal.Insert(payCell);
            return new SuccessResult(Messages.productAdded);
        }

        public IResult Update(Paycell payCell)
        {
            _paycellDal.Update(payCell);
            return new SuccessResult(Messages.productUpdated);
        }
    }
}
