﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.EntityLayer.Concrete
{
    public class FavoriteComment
    {
        public int FavoriteCommentId { get; set; }
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public Comment Comment { get; set; }
        public User User { get; set; }
    }
}
