using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAccommodation.Model
{
    public class Reserve
    {
        public List<Guest> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReserveDuration { get; set; }

        public Reserve(int reserveDuration)
        {
            ReserveDuration = reserveDuration;
        }

        public void GuestRegister(List<Guest> guests)
        {
            if (guests == null || guests.Count < 1)
            {
                throw new ArgumentException("The Guests List cannot be null or empty");
            }
            CapacityVerifier(guests);
            Guests = guests;
        }

        public void SuiteRegister(Suite suite) => Suite = suite;

        public int GuestsAmount() => Guests.Count;

        public decimal TotalToPay()
        {
            decimal totalToPay = ReserveDuration * Suite.DailyPrice;

            if (ReserveDuration >= 10)
            {
                totalToPay *= 0.9m; 
            }
            return totalToPay;
        }

        public void CapacityVerifier(List<Guest> guests)
        {
            if (guests.Count > Suite.Capacity)
            {
                throw new ArgumentException("The Guests amount is over the suite capacity");
            }
        }
    }
}