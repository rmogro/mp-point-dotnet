using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoPago.Client.Point
{
    public class PointPaymentIntentAdditionalInfoRequest
    {
        public string ExternalReference { get; set; }
        public bool? PrintOnTerminal { get; set; }
        public decimal TicketNumber { get; set; }
    }
}
