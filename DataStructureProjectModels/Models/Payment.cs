namespace DataStructureProjectModels.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public double amount { get; set; }

        public Payment() { }

        public Payment(int paymentId, int reservationId, int userId, double amount)
        {
            PaymentId = paymentId;
            ReservationId = reservationId;
            UserId = userId;
            this.amount = amount;
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
