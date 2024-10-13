namespace BellmanFordAlgo.Models
{
    public class Currency
    {
        public string? Name { get; set; }
        public double? Price { get; set; }
        public List<Currency> Initiate()
        {
            var result = new List<Currency>();
            result.Add(new Currency()
            {
                Name = "USDT",
                Price = 1
            });
            result.Add(new Currency()
            {
                Name = "BTC",
                Price = 62825.92
            });
            result.Add(new Currency()
            {
                Name = "ETH",
                Price = 2464.72
            });
            result.Add(new Currency()
            {
                Name = "BNB",
                Price = 574
            });
            return result;
        }
    }
}
