using System;

public class Reservation
{

   public enum ReservationStatus
    {
    Pending,
    Confirmed,
    CheckedIn,
    CheckedOut,
    Cancelled
    }
    public int ReservationId { get;}
    public DateTime CheckInDate { get;}
    public DateTime CheckOutDate { get;}
    public ReservationStatus Status { get;  private set; }
    public Room Room { get;}

    public double Total
    {
        get
        {
            TimeSpan duration = CheckOutDate - CheckInDate;
           double TotalPrice = Room.NightlyRate * duration.Days;
            return TotalPrice;
        }
    }
    public Reservation( int id ,DateTime checkIn , DateTime checkOut , Room room  )
    {
        if (id <= 0) 
        {
            throw new ArgumentException("Reservation ID must be greater than zero.", nameof(id));
        }
        ReservationId = id;

        if (checkIn >= checkOut)
        {
            throw new ArgumentException("Check-in date must be before check-out date.");
        }
        CheckInDate = checkIn;
        CheckOutDate = checkOut;
        if (room == null)
        {
            throw new ArgumentNullException(nameof(room), "Room cannot be null.");
        }
        if (room.IsUnderMaintenance)
        {
            throw new InvalidOperationException("Room is Under Maintenance");
        }
        Room = room;
        Status = ReservationStatus.Pending;
        room.AddReservation(this);
    }
    public void Confirm()
    {
        if (Status != ReservationStatus.Pending)
        {
            throw new InvalidOperationException($"Cannot confirm a reservation with status {Status}.");
            
        }
        Status = ReservationStatus.Confirmed;


    }
    public void CheckIn()
    {
        if (Status != ReservationStatus.Confirmed)
        {
            throw new InvalidOperationException($"Cannot check in a reservation with status {Status}");
        }
        Status = ReservationStatus.CheckedIn;


    }
    public void CheckOut()
    {
        if (Status != ReservationStatus.CheckedIn)
        {
            throw new InvalidOperationException($"Cannot check out a reservation with status {Status}");
        }
        Status = ReservationStatus.CheckedOut;


    }
    public void Cancel()
    {
        if (Status != ReservationStatus.Pending && Status!=ReservationStatus.Confirmed)
        { 
            throw new InvalidOperationException($"Cannot cancel in a reservation with status {Status}");
        }
        Status = ReservationStatus.Cancelled;
    }
}
