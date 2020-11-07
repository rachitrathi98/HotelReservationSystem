using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HotelReservation
{
    class Hotel
    {
        public string hotelName;

        public int ratesRegular;
        /// <summary>
        /// Initializes a new instance of the <see cref="Hotel"/> class.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="rates">The rates.</param>
        public Hotel(string hotelName, int ratesRegular)
        {
            this.hotelName = hotelName;

            this.ratesRegular = ratesRegular;
        }

    }
}
