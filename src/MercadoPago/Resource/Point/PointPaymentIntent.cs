using MercadoPago.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoPago.Resource.Point
{
    public class PointPaymentIntent : IResource
    {
        public string Id { get; set; }
        public string State { get; set; }
        public long? Amount { get; set; }
        public string DeviceId { get; set; }
        public PointPaymentIntentPayment Payment { get; set; }
        public PointPaymentIntentAdditionalInfo AdditionalInfo { get; set; }
        public string PaymentMode { get; set; }

        public string Status { get; set; }
        public DateTime? CreatedOn { get; set; }

        public IList<PointStatusPaymentIntent> Events { get; set; }
        public MercadoPagoResponse ApiResponse { get; set; }
    }
}
