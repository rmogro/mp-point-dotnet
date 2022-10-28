namespace MercadoPago.Client.Point
{
    public enum OperatingMode
    {
        /// <summary>
        /// PDV: point of sale, integrated mode with the API.
        /// </summary>
        PDV,
        /// <summary>
        /// STANDALONE: default device configuration, mode not integrated with the API.
        /// </summary>
        STANDALONE
    }
}
