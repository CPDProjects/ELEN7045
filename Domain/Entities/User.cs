using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User: IUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserCategory Category { get; set; }
        public UserRole[] Roles { get; set; }
        public Region Jurisdiction { get; set; }
    }
}
