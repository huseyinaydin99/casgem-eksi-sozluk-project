using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.EntityLayer.Concrete
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string Title { get; set; }
        public List<Comment> Comments { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
