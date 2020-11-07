using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HotelReservation
{
    public class Hotel
    {
        public string hotelName;

        public int ratesRegular;
        public string customerType;
        public int rating;
        /// <summary>
        /// Initializes a new instance of the <see cref="Hotel"/> class.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="rates">The rates.</param>
        public Hotel(string hotelName, int ratesRegular, int rating, string customerType)
        {
            this.hotelName = hotelName;
            this.rating = rating;
            this.ratesRegular = ratesRegular;
            this.customerType = customerType;
        }

    }
}
