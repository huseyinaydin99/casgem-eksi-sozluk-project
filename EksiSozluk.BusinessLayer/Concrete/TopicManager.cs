using EksiSozluk.BusinessLayer.Abstract;
using EksiSozluk.DataAccessLayer.Abstract;
using EksiSozluk.EntityLayer.Concrete;

namespace EksiSozluk.BusinessLayer.Concrete
{
    public class TopicManager : ITopicService
    {
        private readonly ITopicDal _topicDal;

        public TopicManager(ITopicDal topicDal)
        {
            _topicDal = topicDal;
        }

        public void TDelete(Topic t)
        {
            _topicDal.Delete(t);
        }

        public Topic TGetByID(int id)
        {
          return _topicDal.GetByID(id);
        }

        public List<Topic> TGetList()
        {
            return _topicDal.GetList();
        }

        public void TInsert(Topic t)
        {
            _topicDal.Insert(t);
        }

        public void TUpdate(Topic t)
        {
            _topicDal.Update(t);
        }
    }
}