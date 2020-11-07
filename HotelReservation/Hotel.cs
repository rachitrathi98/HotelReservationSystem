using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    class Hotel
    {
        HotelType type;//Hotel name
        private readonly double RATE; //Weekday rate of hotel
        /// <summary>
        /// Parameterized constructor of Hotel
        /// </summary>
        /// <param name="hotelType"></param>
        public Hotel(HotelType hotelType)
        {
            this.type = hotelType;
            try
            {
                if (hotelType.Equals(HotelType.LAKEWOOD))
                {
                    this.RATE = 110;
                }
                if (hotelType.Equals(HotelType.BRIDGEWOOD))
                {
                    this.RATE = 150;
                }
                if (hotelType.Equals(HotelType.RIDGEWOOD))
                {
                    this.RATE = 220;
                }
            }
            catch (HotelReservationException)
            {
                throw new HotelReservationException(HotelReservationException.ExceptionType.INVALID_HOTEL_TYPE, "Invalid Hotel Type");
            }
        }
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Hotel()
        { 
        }
    }
}
