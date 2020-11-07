using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservation
{
    class HotelReservation
    {
        public List<Hotel> list;
        public HotelReservation()
        {
            list = new List<Hotel>();

        }
        /// <summary>
        /// UC1: Adds the hotel.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="rateRegular">The rate regular.</param>
        public void AddHotel(string hotelName, int rateRegular)
        {
            Hotel hotel = new Hotel(hotelName, rateRegular);
            list.Add(hotel);
                      
        }
        /// <summary>
        /// UC2: Finds the cheapest hotel.
        /// </summary>
        public void FindCheapestHotel()
        {
            try
            {
                Console.WriteLine("Enter the start date(dd/mm/yyyy):");
                DateTime start = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter the end date(dd/mm/yyyy):");
                DateTime end = DateTime.Parse(Console.ReadLine());
                int noOfDays = (int)(end - start).TotalDays;
                Dictionary<string, int> hotelRates = new Dictionary<string, int>();
                foreach (var v in list)
                {
                    hotelRates.Add(v.hotelName, v.ratesRegular * noOfDays);
                }
                var sortedDict = from entry in hotelRates orderby entry.Value ascending select entry;
                Console.WriteLine("The Cheapest Hotel is {0} with rate {1}",sortedDict.First().Key, sortedDict.First().Value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
