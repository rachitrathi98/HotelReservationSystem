using System;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Hotel Reservation System");
            HotelReservation hotelReservation = new HotelReservation();
            ///Add Hotels in list
            hotelReservation.AddHotel("Lakewood", 110);
            hotelReservation.AddHotel("Bridgewood", 160);
            hotelReservation.AddHotel("Ridgewood", 220);

        }
    }
}
