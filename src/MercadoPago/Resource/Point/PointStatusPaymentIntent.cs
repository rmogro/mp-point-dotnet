using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoPago.Resource.Point
{
    public class PointStatusPaymentIntent
    {
        public string PaymentIntentId { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
