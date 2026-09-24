using System;
using static Reservation;

public class Room
{

    public enum TypeOfRoom
    {
        Single,
        Double,
        Suite
    }
    private List<Reservation> RoomReservationList = new List<Reservation>();
    public int RoomNumber { get; }
    public TypeOfRoom RoomType { get; }
    public int NightlyRate { get; private set; }
    public bool IsUnderMaintenance { get; private set; }
    public Room(int num, TypeOfRoom type, int rate)
    {
        if (num <= 0)
        {
            throw new ArgumentException("Room Number Must be Greater than Zero", nameof(num));
        }
        RoomNumber = num;
        if (rate <= 0)
        {
            throw new ArgumentException("Nightly rate must be greater than zero..");
        }
        NightlyRate = rate;
        RoomType = type;
    }

    public void StartMaintenance()
    {
        IsUnderMaintenance = true;
    }
    public void EndMaintenance()
    {
        IsUnderMaintenance = false;
    }

    public void ChangeRate(int newRate)
    {
        if (newRate <= 0)
        {
            throw new ArgumentException("Nightly rate must be greater than zero.");
        }

        NightlyRate = newRate;

    }

    public bool IsAvailable(DateTime NewcheckIn, DateTime NewcheckOut)
    { 
        foreach (Reservation reservation in RoomReservationList)
        {
            if(reservation.Status == ReservationStatus.CheckedOut || reservation.Status == ReservationStatus.Cancelled)
            {
                continue;
            }
            if(reservation.CheckOutDate > NewcheckIn && reservation.CheckInDate < NewcheckOut)
            {
               // Console.WriteLine("booked");
                return false;
            }
        }
        return true;
    }

    public void AddReservation(Reservation reservation)
    {
        if (reservation == null)
        {
            throw new ArgumentNullException(
                nameof(reservation),
                "Reservation cannot be null.");
        }

        if (IsAvailable(reservation.CheckInDate, reservation.CheckOutDate))
        {
            RoomReservationList.Add(reservation);
        }
        else
        {
            throw new InvalidOperationException(
                $"Room {RoomNumber} is already booked from " +
                $"{reservation.CheckInDate:d} to {reservation.CheckOutDate:d}.");
        }
    }
}
