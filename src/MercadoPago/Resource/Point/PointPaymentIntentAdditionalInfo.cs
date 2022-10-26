namespace MercadoPago.Resource.Point
{
    public class PointPaymentIntentAdditionalInfo
    {
        public string ExternalReference { get; set; }
        public bool? PrintOnTerminal { get; set; }
        public string TicketNumber { get; set; }
    }
}
