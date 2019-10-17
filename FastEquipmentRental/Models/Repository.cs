﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastEquipmentRental.Models
{
    public static class Repository
    {
        private static List<EquipmentRequest> requests = new List<EquipmentRequest>();

        public static IEnumerable<EquipmentRequest> Requests
        {
            get { return requests; }
        }

        public static void AddRequest(EquipmentRequest request)
        {
            requests.Add(request);
        }
    }
}