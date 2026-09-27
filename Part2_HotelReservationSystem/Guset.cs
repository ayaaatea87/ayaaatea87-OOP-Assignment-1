using System;
using System.Security.Principal;

public class Guest

{
    public int GuestId { get; }
    public string FullName { get; }
    public string PhoneNumber { get;}

    private List<Reservation> reservationsList = new List<Reservation>();
    public IReadOnlyList<Reservation> GuestReservations 
    {
        get
        {

            return reservationsList;
        }
    }
    public Guest( int guestId ,  string name,  string phone)
	{
        if (guestId <= 0)
        {
            throw new ArgumentException("Guest ID must be greater than zero.", nameof(guestId));
        }
        GuestId = guestId;
            if (string.IsNullOrWhiteSpace(name))
            {

                throw new ArgumentException(" name cannot be null ",nameof(name));
            }
        FullName = name;
        if (string.IsNullOrWhiteSpace(phone))
        {

            throw new ArgumentException("phone number cannot be null",nameof(phone));
        }
        PhoneNumber = phone ;

	}

    public void AddReservation(Reservation reservation)
    {
        reservationsList.Add(reservation);
    }
}
