﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IModel
    {
        int Id { get; set; }
        string ReferenceNo { get; set; }
    }
}
