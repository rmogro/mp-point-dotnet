using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoPago.Client;
using MercadoPago.Client.Payment;
using MercadoPago.Client.Point;
using MercadoPago.Http;
using MercadoPago.Serialization;
using Xunit;

namespace MercadoPago.Tests.Client.Point
{
    public class PointClientTest: BaseClientTest
    {
        private readonly PointClient client;
        private readonly RequestOptions options;

        public PointClientTest(ClientFixture clientFixture) : base(clientFixture)
        {
            client = new PointClient();
            options = new RequestOptions();
            options.CustomHeaders.Add("x-test-scope", "sandbox");
        }

        [Fact]
        public void Get_Success()
        {
            var id = "364cc168-ac01-4754-9366-1003f998055f";
            var paymentIntent = client.Get(id, options);
            Assert.True(true);
        }

        [Fact]
        public void GetLastStatus_Success()
        {
            var id = "364cc168-ac01-4754-9366-1003f998055f";
            var paymentIntent = client.GetLastStatus(id, options);
            Assert.True(true);
        }

        [Fact]
        public void GetList_Success()
        {
            var paymentIntent = client.GetList(DateTime.Today, DateTime.Today.AddDays(1), options);
            Assert.True(true);
        }

        [Fact]
        public void Cancel_Success()
        {
            var deviceId = "INGENICO_MOVE2500__ING-ARG-4567446831";
            var id = "0753e3b8-12e9-4b41-a51e-f162700b0d6a";
            var paymentIntent = client.Cancel(deviceId, id, options);
            Assert.True(true);
        }
    }
}
