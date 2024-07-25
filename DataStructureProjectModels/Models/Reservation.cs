namespace DataStructureProjectModels.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int NumberOfSlotBook { get; set; }
        public int SiteId { get; set; }
        public int TouristId { get; set; }
        public int paymentId { get; set; }


        public Reservation() { }

        public Reservation(int reservationId, int numberOfSlotBook, int siteId, int touristId, int paymentId)
        {
            ReservationId = reservationId;
            NumberOfSlotBook = numberOfSlotBook;
            SiteId = siteId;
            TouristId = touristId;
            this.paymentId = paymentId;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
