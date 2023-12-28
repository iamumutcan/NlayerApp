using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Core.Model
{
    public class UserAddress : BaseEntity
    {
        public int UserID { get; set; }
        public User AppUser { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }

    }
}
