namespace Part2_HotelReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room(101, Room.TypeOfRoom.Single, 1000);
            // room.StartMaintenance();
            room.ChangeRate(1200);
            Guest G1 = new Guest(200, "aya", "01004604332");
            Reservation r1 = new Reservation(100, new DateTime(2026, 9, 10),
                              new DateTime(2026, 9, 15), room);
            r1.Cancel();
            Console.WriteLine(r1.Status);

            Reservation r2 = new Reservation(100, new DateTime(2026, 9, 15),
                                new DateTime(2026, 9, 20), room);
            r2.Confirm();
            r2.CheckIn();
            Console.WriteLine(r2.Status);
            Reservation r3 = new Reservation(100, new DateTime(2026, 9, 10),
                              new DateTime(2026, 9, 15), room);
            r3.Confirm();
            Console.WriteLine(r3.Status);

            G1.AddReservation(r1);
            G1.AddReservation(r3);
            G1.AddReservation(r2);
            foreach (Reservation reservation in G1.GuestReservations)
            {
                Console.WriteLine(
                    $"ID: {reservation.ReservationId}, " +
                    $"Check-in: {reservation.CheckInDate:d}, " +
                    $"Check-out: {reservation.CheckOutDate:d}, " +
                    $"Status: {reservation.Status}"
                );
            }

        }
    }
}
