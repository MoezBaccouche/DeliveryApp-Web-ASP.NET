﻿using DeliveryApp.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.API.Models.DTO
{
    public class CartDto
    {
        public IEnumerable<ProductForCheckout> Products { get; set; }
        public IEnumerable<CategoryForCartDto> Categories { get; set; }
        public ClientForCartDto Client { get; set; }
    }
}
