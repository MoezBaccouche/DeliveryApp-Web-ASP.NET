﻿using DeliveryApp.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models.ViewModels
{
    public class ProfileViewModel
    {
        public Admin Admin { get; set; }
        public int NbDeliveredOrders { get; set; }
        public int NbClients { get; set; }
        public IEnumerable<DeliveryMan> DeliveryMen { get; set; }
    }
}
