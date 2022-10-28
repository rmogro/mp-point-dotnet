using MercadoPago.Http;
using MercadoPago.Resource.Point;
using MercadoPago.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoPago.Client.Point
{
    public class DeviceClient:MercadoPagoClient<DevicesPoint>
    {
        public DeviceClient(IHttpClient httpClient, ISerializer serializer)
           : base(httpClient, serializer)
        {
        }
        public DeviceClient(IHttpClient httpClient)
            : base(httpClient, null)
        {
        }
        public DeviceClient(ISerializer serializer)
            : base(null, serializer)
        {
        }
        public DeviceClient()
            : base(null, null)
        {
        }

        public DevicesPoint GetPointDevices(PointDeviceAdditionalInfoResquest request, RequestOptions requestOptions = null)
        {
            return Send(
                "/point/integration-api/devices",
                HttpMethod.GET,
                request,
                requestOptions
                );
        }

        public DevicesPoint ChangeOperatingMode(string deviceId, PointDeviceOperatingModeRequest request, RequestOptions options = null)
        {

            return Send(
                $"/point/integration-api/devices/{deviceId}",
                HttpMethod.PATCH,
                request,
                options
                );
        }
    }
}
