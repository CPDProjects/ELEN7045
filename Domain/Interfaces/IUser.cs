﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IUser
    {
        int Id { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        UserCategory Category { get; set; }
        UserRole[] Roles { get; set; }
        Region Jurisdiction { get; set; }
    }
}
