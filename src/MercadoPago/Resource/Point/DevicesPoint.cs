using MercadoPago.Http;
using System.Collections.Generic;

namespace MercadoPago.Resource.Point
{
    public class DevicesPoint: IResource
    {
        public List<Device> Devices { get; set; }
        public ResultsPaging Paging { get; set; }
        public MercadoPagoResponse ApiResponse { get; set; }
    }
}
