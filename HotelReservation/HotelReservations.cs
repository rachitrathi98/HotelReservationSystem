using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservation
{
    public class HotelReservations
    {
        public List<Hotel> list;
        public HotelReservations()
        {
            list = new List<Hotel>();

        }
        /// <summary>
        /// UC1: Adds the hotel.
        /// </summary>
        /// <param name="hotelName">Name of the hotel.</param>
        /// <param name="rateRegular">The rate regular.</param>
        public void AddHotel(string hotelName, int rateRegular, int rating, string type)
        {
            Hotel hotel = new Hotel(hotelName, rateRegular, rating, type);
            list.Add(hotel);
                      
        }
        /// <summary>
        /// UC2: Finds the cheapest hotel.
        /// </summary>
        public Dictionary<string, int> FindCheapestHotel(string type, DateTime start, DateTime end)
        {
            Dictionary<string, int> rateRecord = new Dictionary<string, int>();

          
                start = DateTime.Parse(Console.ReadLine());
                end = DateTime.Parse(Console.ReadLine());

                    int rateOfLake = 0;
                    int rateOfBridge = 0;
                    int rateOfRidge = 0;
                    if (start > end)
                    {
                        Console.WriteLine("Enter the date properly");
                    }
                    TimeSpan diff = end - start;
                    int days = diff.Days;
                for (var i = 0; i <= days; i++)
                {
                    var testDate = start.AddDays(i);
                    if (testDate.DayOfWeek == DayOfWeek.Saturday || testDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        if (type.Equals("Regular"))
                        {
                            rateOfLake += 90;
                            rateOfBridge += 60;
                            rateOfRidge += 150;
                        }

                        else
                        {
                            rateOfLake += 80;
                            rateOfBridge += 50;
                            rateOfRidge += 40;
                        }
                    }
                    else
                    {
                        if (type.Equals("Regular"))
                        {
                            rateOfLake += 110;
                            rateOfBridge += 160;
                            rateOfRidge += 220;
                        }
                        else
                        {
                            rateOfLake += 80;
                            rateOfBridge += 110;
                            rateOfRidge += 100;
                        }
                    }
                }
                rateRecord.Add("Lakewood", rateOfLake);
                rateRecord.Add("Bridgewood", rateOfBridge);
                rateRecord.Add("Ridgewood", rateOfRidge);
                int min = rateRecord.Select(x => x.Value).Min();
                Dictionary<string, int> cheapHotel = new Dictionary<string, int>();

                foreach (KeyValuePair<string, int> kv in rateRecord)
                {
                    if (kv.Value == min)
                    {
                        cheapHotel.Add(kv.Key, kv.Value);
                    }
                }
            return cheapHotel;
        }

    }
}
