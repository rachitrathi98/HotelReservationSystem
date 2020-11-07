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
        /// TC2 Compare the Cheapest Hotel for Given Date
        /// </summary>
        [TestMethod]
        public void FindCheapestHotelForGivenDate_TC2()
        {
            DateTime start = DateTime.Parse("10/10/2020");
            DateTime end = DateTime.Parse("10/11/2020");
            string expectedHotel = "Lakewood";
            int expectedRate = 220;
            string actualHotel = "";
            int actualRate = 0;
            try
            {
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
            catch (HotelCustomException e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
