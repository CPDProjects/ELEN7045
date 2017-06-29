using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FaultOperator : IUser
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public UserCategory Category { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public UserRole[] Roles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Region Jurisdiction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
