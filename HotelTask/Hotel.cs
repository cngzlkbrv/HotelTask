

namespace HotelTask
{
    internal class Hotel
    {
        public string Name  { get; set; }
       
        private Room[] rooms =new Room[0];


        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[rooms.Length - 1] = room;

        }

        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
            {
                throw new NullReferenceException("Duz deyil");
            }
            else
            {
                foreach (Room room in rooms)
                {
                    if(room.Id == roomId)
                    {
                        if (room.IsAvailable)
                        {
                            room.IsAvailable = false;
                        }
                        else
                        {
                            throw new NotAvailableException("Otaq doludur");
                        }
                    }
                }
            }
        }
        public Hotel(string name)
        {
            Name = name;   
        }
    }


}
