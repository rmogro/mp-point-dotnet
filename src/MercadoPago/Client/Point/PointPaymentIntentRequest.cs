using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoPago.Client.Point
{
    public class PointPaymentIntentRequest: IdempotentRequest
    {
        public decimal Amount { get; set; }
        public PointPaymentIntentAdditionalInfoRequest AdditionalInfo { get; set; }
    }
}
