﻿using NBSTicketing.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBSTicketing.Models.ViewModels
{
    public class OrdersViewModel
    {
        public List<Order> Orders { get; internal set; }
    }
}
