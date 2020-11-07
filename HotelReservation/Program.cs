using System;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Hotel Reservation System");
            Console.WriteLine("Enter start date of your stay in dd/mm/yyyy format");
            string startDate = Console.ReadLine();
            Console.WriteLine("Enter end date of your stay in dd/mm/yyyy format");
            string endDate = Console.ReadLine();
            Service customerService = new Service();
            customerService.FindCheapHotel(startDate, endDate);

        }
    }
}
