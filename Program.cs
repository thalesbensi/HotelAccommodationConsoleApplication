
using HotelAccommodation.Model;

List<Guest> guests = new List<Guest>();

Guest g1 = new Guest(name:"Michel", surname:"Braga");
Guest g2 = new Guest(name: "Gabriel", surname: "Nargas");

guests.Add(g1);
guests.Add(g2);


Suite suite = new Suite(suiteType: "Premium", capacity: 3, dailyPrice: 30);

Reserve reserve = new Reserve(reserveDuration: 10);
reserve.SuiteRegister(suite);
reserve.GuestRegister(guests);

Console.WriteLine($"Guests: {reserve.GuestsAmount()}");
Console.WriteLine($"Total Price: {reserve.TotalToPay().ToString("C2")}");
