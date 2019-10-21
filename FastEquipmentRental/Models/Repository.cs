
using System.Collections.Generic;


namespace FastEquipmentRental.Models
{
    public static class Repository
    {
        public static int requestIDCounter = 0;

        private static List<EquipmentRequest> requests = new List<EquipmentRequest>();

        private static List<Equipment> equipments = new List<Equipment>()
            {
                new Equipment {
                    Id = 1,
                    Type = "Laptop",
                    Description = "MacBook Pro 2017",
                    Availability = true,
                },

                new Equipment {
                    Id = 2,
                    Type = "Laptop",
                    Description = "MacBook Air 2019",
                    Availability = false,
                },

                new Equipment {
                    Id = 3,
                    Type = "Phone",
                    Description = "Samsung Galaxy",
                    Availability = true,
                },

                new Equipment {
                    Id = 4,
                    Type = "Tablet",
                    Description = "iPad Mini",
                    Availability = true,
                },

                new Equipment {
                    Id = 5,
                    Type = "Other",
                    Description = "Ethernet Adapter to USB-C",
                    Availability = true,
                },
            };

        public static IEnumerable<EquipmentRequest> Requests
        {
            get { return requests; }
        }

        public static IEnumerable<Equipment> Equipments
        {
             get { return equipments; }
        }

        public static void AddRequest(EquipmentRequest request)
        {
            requestIDCounter++;
            request.Id = requestIDCounter;
            requests.Add(request);
        }
    }
}
