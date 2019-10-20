using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FastEquipmentRental.Models
{
    public static class Repository
    {
        public static int IdCounter = 0;

        private static List<EquipmentRequest> requests = new List<EquipmentRequest>();

        public static IEnumerable<EquipmentRequest> Requests
        {
            get { return requests; }
        }

        public static void AddRequest(EquipmentRequest request)
        {
            IdCounter++;
            request.Id = IdCounter;
            requests.Add(request);
        }
    }
}
