using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.EntityLayer.Concrete
{
    public class ContactCategory
    {
        public int ContactCategoryId { get; set; }
        public string ContactCategoryTitle { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
