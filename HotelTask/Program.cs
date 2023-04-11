namespace HotelTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("otaq13",5,4);
            Room room2 = new Room("otaq56", 7, 2);
            Hotel hotel = new Hotel("Transilvaniya");
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            try
            {
                hotel.MakeReservation(1);
                hotel.MakeReservation(1);
                hotel.MakeReservation(1);
            }
            catch(NotAvailableException ex) 
            {
                throw new NotAvailableException("Otaq doludur");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.WriteLine("--Bitdi--");
            }
        }
    }
}