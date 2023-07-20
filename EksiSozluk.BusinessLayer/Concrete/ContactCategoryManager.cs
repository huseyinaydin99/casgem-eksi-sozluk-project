using EksiSozluk.BusinessLayer.Abstract;
using EksiSozluk.DataAccessLayer.Abstract;
using EksiSozluk.EntityLayer.Concrete;

namespace EksiSozluk.BusinessLayer.Concrete
{
    public class ContactCategoryManager : IContactCategoryService
    {
        private readonly IContactCategoryDal _contactCategoryDal;

        public ContactCategoryManager(IContactCategoryDal contactCategoryDal)
        {
            _contactCategoryDal = contactCategoryDal;
        }

        public void TDelete(ContactCategory t)
        {
            _contactCategoryDal.Delete(t);
        }

        public ContactCategory TGetByID(int id)
        {
          return _contactCategoryDal.GetByID(id);
        }

        public List<ContactCategory> TGetList()
        {
            return _contactCategoryDal.GetList();
        }

        public void TInsert(ContactCategory t)
        {
            _contactCategoryDal.Insert(t);
        }

        public void TUpdate(ContactCategory t)
        {
            _contactCategoryDal.Update(t);
        }
    }
}