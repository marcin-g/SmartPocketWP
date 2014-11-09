﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPocket.Intefaces.Model
{
    interface ICharge
    {
        int ID { get; set; }
        double Amount { get; set; }
        string Description { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        ICollection<ITag> Tags { get; set; }
    }
}
