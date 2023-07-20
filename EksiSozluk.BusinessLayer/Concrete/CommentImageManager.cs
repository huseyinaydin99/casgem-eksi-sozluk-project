using EksiSozluk.BusinessLayer.Abstract;
using EksiSozluk.DataAccessLayer.Abstract;
using EksiSozluk.EntityLayer.Concrete;

namespace EksiSozluk.BusinessLayer.Concrete
{
    public class CommentImageManager : ICommentImageService
    {
        private readonly ICommentImageDal _commentImageDal;

        public CommentImageManager(ICommentImageDal commentImageDal)
        {
            _commentImageDal = commentImageDal;
        }

        public void TDelete(CommentImage t)
        {
            _commentImageDal.Delete(t);
        }

        public CommentImage TGetByID(int id)
        {
            return _commentImageDal.GetByID(id);
        }

        public List<CommentImage> TGetList()
        {
            return _commentImageDal.GetList();
        }

        public void TInsert(CommentImage t)
        {
            _commentImageDal.Insert(t);
        }

        public void TUpdate(CommentImage t)
        {
            _commentImageDal.Update(t);
        }
    }
}