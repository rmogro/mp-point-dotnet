using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MercadoPago.Client.User;
using MercadoPago.Error;
using MercadoPago.Http;
using MercadoPago.Resource.Point;
using MercadoPago.Serialization;

namespace MercadoPago.Client.Point
{
    public class PointClient : MercadoPagoClient<PointPaymentIntent>
    {
        public PointClient(IHttpClient httpClient, ISerializer serializer): base(httpClient, serializer)
        {
        }

        public PointClient(IHttpClient httpClient): base(httpClient, null)
        {
        }

        public PointClient(ISerializer serializer): base(null, serializer)
        {
        }

        public PointClient(): base(null, null)
        {
        }

        public PointPaymentIntent Get(string id, RequestOptions requestOptions = null)
        {
            return Send(
                $"/point/integration-api/payment-intents/{id}",
                HttpMethod.GET,
                null,
                requestOptions);
        }

        public Task<PointPaymentIntent> GetAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return SendAsync(
                $"/point/integration-api/payment-intents/{id}",
                HttpMethod.GET,
                null,
                requestOptions,
                cancellationToken);
        }

        public PointPaymentIntent GetLastStatus(string id, RequestOptions requestOptions = null)
        {
            return Send(
                $"/point/integration-api/payment-intents/{id}/events",
                HttpMethod.GET,
                null,
                requestOptions);
        }

        public Task<PointPaymentIntent> GetLastStatusAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return SendAsync(
                $"/point/integration-api/payment-intents/{id}/events",
                HttpMethod.GET,
                null,
                requestOptions,
                cancellationToken);
        }

        public PointPaymentIntent GetList(DateTime startDate, DateTime endDate, RequestOptions requestOptions = null)
        {
            return Send(
                $"/point/integration-api/payment-intents/events?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}",
                HttpMethod.GET,
                null,
                requestOptions);
        }

        public Task<PointPaymentIntent> GetListAsync(DateTime startDate, DateTime endDate, RequestOptions requestOptions = null)
        {
            return SendAsync(
                $"/point/integration-api/payment-intents/events?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}",
                HttpMethod.GET,
                null,
                requestOptions);
        }

        public PointPaymentIntent Cancel(string deviceId, string id, RequestOptions requestOptions = null)
        {
            return Send(
                $"/point/integration-api/devices/{deviceId}/payment-intents/{id}",
                HttpMethod.DELETE,
                null,
                requestOptions);
        }

        public Task<PointPaymentIntent> CancelAsync(string deviceId, string id, RequestOptions requestOptions = null)
        {
            return SendAsync(
                $"/point/integration-api/devices/{deviceId}/payment-intents/{id}",
                HttpMethod.DELETE,
                null,
                requestOptions);
        }
    }
}
