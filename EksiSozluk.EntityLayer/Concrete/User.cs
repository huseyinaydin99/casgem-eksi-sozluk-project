using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.EntityLayer.Concrete
{
    public class User : IdentityUser<int>
    {
        //public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NameSurname { get; set; }
        public DateTime DateofBirth { get; set; }
        public string ImageUrl { get; set; }
        public bool Gender { get; set; }
        public bool UserType { get; set; } //true = admin || false = user
        public List<Topic> Topics { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Expression> Expressions { get; set; }
        public List<CommentImage> CommentImages { get; set; }
        public int? ConfirmCode { get; set; }
    }
}
