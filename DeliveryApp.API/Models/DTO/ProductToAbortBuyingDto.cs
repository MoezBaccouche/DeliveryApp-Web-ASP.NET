﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.API.Models.DTO
{
    public class ProductToAbortBuyingDto
    {
        public int IdProduct { get; set; }
        public int IdOrder { get; set; }
    }
}
