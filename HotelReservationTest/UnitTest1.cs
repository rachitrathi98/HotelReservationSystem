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
            string start = "11/09/2020";
            string end = "12/09/2020";
            string expectedHotel = "Lakewood";
            int expectedRate = 220;
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
        public void FindCheapestandBestRatedHotelForGivenDate()
        {
            string start = "11/09/2020";
            string end = "12/09/2020";
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
        /// <summary>
        /// TC7: Finds the best rated hotel for given date t c2.
        /// </summary>
        [TestMethod]
        public void FindBestRatedHotelForGivenDate()
        {
            string start = "11/09/2020";
            string end = "12/09/2020";
            string expectedHotel = "Ridgewood";
            int expectedRate = 370;
            string actualHotel = "";
            int actualRate = 0;
            HotelReservations reservation = new HotelReservations();
            Dictionary<string, int> hotel = reservation.FindBestRatedHotel("Regular", start, end);
            foreach (KeyValuePair<string, int> kv in hotel)
            {
                actualHotel = kv.Key;
                actualRate = kv.Value;
            }
            Assert.AreEqual(expectedHotel, actualHotel);
            Assert.AreEqual(expectedRate, actualRate);
        }
        /// <summary>
        /// TC 10: Finds the cheapest and best rated hotel for given date in reward category.
        /// </summary>
        [TestMethod]
        public void FindCheapestandBestRatedHotelForGivenDateReward()
        {
            string start = "11/09/2020";
            string end = "12/09/2020";
            string expectedHotel = "Ridgewood";
            int expectedRate = 140;
            string actualHotel = "";
            int actualRate = 0;
            HotelReservations reservation = new HotelReservations();
            Dictionary<string, int> hotel = reservation.FindCheapestandBestRatedHotelReward("Rewards", start, end);
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

