using Binance.Net.Clients;
using Binance.Net.Interfaces;
using CryptoExchange.Net.Objects;

namespace BellmanFordAlgo.Models
{
    public class Binance
    {
        public async Task<WebCallResult<IEnumerable<IBinanceTick>>> Get()
        {
            return await new BinanceRestClient() { }.SpotApi.ExchangeData.GetTickersAsync();
        }
    }
}
