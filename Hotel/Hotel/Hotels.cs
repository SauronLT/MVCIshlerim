using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels;

    
    
        public class Hotels
        {
            public string Name { get; set; }
            private Room[] Rooms = new Room[0];

            public Hotels(string name)
            {
                if (string.IsNullOrWhiteSpace(name))
                    throw new Exception("Otelin adı boş ola bilməz!");
                Name = name;
            }

            public void AddRoom(Room room)
            {
                Array.Resize(ref Rooms, Rooms.Length + 1);
                Rooms[Rooms.Length - 1] = room;
                Console.WriteLine("Otaq əlavə olundu.");
            }

            public void MakeReservation(int roomId)
            {
                foreach (var room in Rooms)
                {
                    if (room.Id == roomId)
                    {
                        if (!room.IsAvailable)
                        {
                            Console.WriteLine("Bu otaq artıq doludur!");
                            return;
                        }

                        room.IsAvailable = false;
                        Console.WriteLine("Rezervasiya olundu.");
                        return;
                    }
                }

                Console.WriteLine("Belə bir otaq tapılmadı.");
            }

            public void ShowAllRooms()
            {
                foreach (var room in Rooms)
                {
                    Console.WriteLine(room);
                }
            }
        }

    
