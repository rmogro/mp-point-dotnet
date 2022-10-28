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
        private readonly DeviceClient device;

        public PointClientTest(ClientFixture clientFixture) : base(clientFixture)
        {
            client = new PointClient();
            device = new DeviceClient();
            options = new RequestOptions();
            options.CustomHeaders.Add("x-test-scope", "sandbox");
        }

        [Fact]
        public void Get_Success()
        {
            var id = "3c0b09f1-73c3-4461-9b15-7a926594ca2f";
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

        [Fact]
        public void Create_Success()
        {
            var request = new PointPaymentIntentRequest {
                Amount = 500000,
                AdditionalInfo = new PointPaymentIntentAdditionalInfoRequest {ExternalReference = "PruebaCSharp1", PrintOnTerminal = true, TicketNumber = "PruebaCS1"}
            };

            var deviceId = "INGENICO_MOVE2500__ING-ARG-4567446831";
            var paymentIntent = client.Create(deviceId, request, options);
            Assert.True(true);
        }

        [Fact]
        public void GetPayment()
        {
            var paymentIntent = client.Get("044c2c9f-540c-437f-9cd4-e1b702852ad9", options);
            if (paymentIntent.State == "FINISHED")
            {
                var cliente = new PaymentClient();
                var pay = cliente.Get(paymentIntent.Payment.Id, options);
            }

            Assert.True(true);

        }

        [Fact]
        public void GetList_Devices()
        {
            //var request = new DevicePointAdditionalInfoResquest { IdPos = "", IdStore="", Limit=""}
            var devices = device.GetPointDevices(null,options);
            Assert.True(true);
        }

        [Fact]
        public void ChangeOperatingMode()
        {
            var request = new PointDeviceOperatingModeRequest { OperatingMode = "STANDALONE" };
            var deviceId = "INGENICO_MOVE2500__ING-ARG-4567446831";
            var devices = device.ChangeOperatingMode(deviceId,request,options);
            Assert.True(true);
        }
    }
}
