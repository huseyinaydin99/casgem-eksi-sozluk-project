using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        
        public string CommentText { get; set; }
        public List<Expression> Expressions { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
