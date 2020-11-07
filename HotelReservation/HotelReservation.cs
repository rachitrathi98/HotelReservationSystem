using System;
using System.Collections.Generic;
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
       
    }
}
