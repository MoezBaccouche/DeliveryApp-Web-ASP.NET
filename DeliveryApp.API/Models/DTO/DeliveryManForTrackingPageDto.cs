﻿using DeliveryApp.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.API.Models.DTO
{
    public class DeliveryManForTrackingPageDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[] ImageBase64 { get; set; }
        public Location Location { get; set; }
    }
}
