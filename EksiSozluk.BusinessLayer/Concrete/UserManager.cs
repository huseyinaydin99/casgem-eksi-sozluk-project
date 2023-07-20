using EksiSozluk.BusinessLayer.Abstract;
using EksiSozluk.DataAccessLayer.Abstract;
using EksiSozluk.EntityLayer.Concrete;

namespace EksiSozluk.BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TDelete(User t)
        {
            _userDal.Delete(t);
        }

        public User TGetByID(int id)
        {
          return _userDal.GetByID(id);
        }

        public List<User> TGetList()
        {
            return _userDal.GetList();
        }

        public void TInsert(User t)
        {
            _userDal.Insert(t);
        }

        public void TUpdate(User t)
        {
            _userDal.Update(t);
        }
    }
}
