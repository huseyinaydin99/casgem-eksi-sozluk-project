

using EksiSozluk.BusinessLayer.Abstract;
using EksiSozluk.DataAccessLayer.Abstract;
using EksiSozluk.EntityLayer.Concrete;

namespace EksiSozluk.BusinessLayer.Concrete
{
    public class ExpressionManager : IExpressionService
    {
        private readonly IExpressionDal _expressionDal;

        public ExpressionManager(IExpressionDal expressionDal)
        {
            _expressionDal = expressionDal;
        }

        public void TDelete(Expression t)
        {
            _expressionDal.Delete(t);
        }

        public Expression TGetByID(int id)
        {
          return _expressionDal.GetByID(id);
        }

        public List<Expression> TGetList()
        {
            return _expressionDal.GetList();
        }

        public void TInsert(Expression t)
        {
            _expressionDal.Insert(t);
        }

        public void TUpdate(Expression t)
        {
            _expressionDal.Update(t);
        }
    }
}