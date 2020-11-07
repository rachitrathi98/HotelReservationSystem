using System;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Hotel Reservation System");
            HotelReservations hotelReservation = new HotelReservations();
            ///Add Hotels in list
            hotelReservation.AddHotel("Lakewood", 110, 3, "Regular");
            hotelReservation.AddHotel("Bridgewood", 160, 4, "Regular");
            hotelReservation.AddHotel("Ridgewood", 220, 5, "Regular");
            hotelReservation.AddHotel("Lakewood", 80, 3, "Rewards");
            hotelReservation.AddHotel("Bridgewood", 110, 4, "Rewards");
            hotelReservation.AddHotel("Ridgewood", 100, 5, "Rewards");

        }
    }
}