using HotelReservation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HotelReservationTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC2: Compare the Cheapest Hotel for Given Date
        /// </summary>
        [TestMethod]
        public void FindCheapestHotelForGivenDate()
        {
            DateTime start = DateTime.Parse("11/09/2020");
            DateTime end = DateTime.Parse("12/09/2020");
            string expectedHotel = "Lakewood";
            int expectedRate = 200;
            string actualHotel = "";
            int actualRate = 0;
                HotelReservations reservation = new HotelReservations();
                Dictionary<string, int> hotel = reservation.FindCheapestHotel("Regular", start, end);
                foreach (KeyValuePair<string, int> kv in hotel)
                {
                    actualHotel = kv.Key;
                    actualRate = kv.Value;
                }
                  Assert.AreEqual(expectedHotel, actualHotel);
                Assert.AreEqual(expectedRate, actualRate);    
        }
        /// <summary>
        /// TC6: Finds the cheapestand best rated hotel for given date.
        /// </summary>
        [TestMethod]
        public void FindCheapestandBestRatedHotelForGivenDate_TC2()
        {
            DateTime start = DateTime.Parse("11/09/2020");
            DateTime end = DateTime.Parse("12/09/2020");
            string expectedHotel = "Bridgewood";
            int expectedRate = 200;
            string actualHotel = "";
            int actualRate = 0;
            HotelReservations reservation = new HotelReservations();
            Dictionary<string, int> hotel = reservation.FindCheapestandBestRatedHotel("Regular", start, end);
            foreach (KeyValuePair<string, int> kv in hotel)
            {
                actualHotel = kv.Key;
                actualRate = kv.Value;
            }
            Assert.AreEqual(expectedHotel, actualHotel);
            Assert.AreEqual(expectedRate, actualRate);
        }

    }
}
