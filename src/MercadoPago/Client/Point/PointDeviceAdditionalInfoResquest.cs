using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoPago.Client.Point
{
    public class PointDeviceAdditionalInfoResquest
    {
        public string IdStore { get; set; }
        public string IdPos { get; set; }
        public string Limit { get; set; }
    }
}
