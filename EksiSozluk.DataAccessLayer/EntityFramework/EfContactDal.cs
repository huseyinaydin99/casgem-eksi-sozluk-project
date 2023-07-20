using EksiSozluk.DataAccessLayer.Abstract;
using EksiSozluk.DataAccessLayer.Repositories;
using EksiSozluk.EntityLayer.Concrete;

namespace EksiSozluk.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {

    }
}
