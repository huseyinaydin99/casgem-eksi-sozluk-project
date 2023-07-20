using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.EntityLayer.Concrete
{
    public class FavoriteTopic
    {
        public int FavoriteTopicId { get; set; }
        public int TopicId { get; set; }
        public int UserId { get; set; }
        public Topic Topic { get; set; }
        public User User { get; set; }
    }
}
