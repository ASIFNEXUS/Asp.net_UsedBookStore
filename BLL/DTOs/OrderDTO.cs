﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int BuyerID { get; set; }
        public string DeliveryAddress { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; }

    }
}
