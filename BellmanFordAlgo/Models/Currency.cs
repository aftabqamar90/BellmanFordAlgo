namespace BellmanFordAlgo.Models
{
    public class Currency
    {
        public string? Name { get; set; }
        public double? Price { get; set; }
        public decimal PriceInUsdt { get; set; } = 0;
        public decimal PriceInToken { get; set; } = 0;
        public List<Currency> Initiate()
        {
            var result = new List<Currency>();
            result.Add(new Currency()
            {
                Name = "USDT",
                Price = 0,
            });
            result.Add(new Currency()
            {
                Name = "BTC",
                Price = double.MaxValue,
            });
            result.Add(new Currency()
            {
                Name = "ETH",
                Price = double.MaxValue,
            });
            result.Add(new Currency()
            {
                Name = "BNB",
                Price = double.MaxValue,
            });
            result.Add(new Currency()
            {
                Name = "LTC",
                Price = double.MaxValue,
            });
            result.Add(new Currency()
            {
                Name = "SOL",
                Price = double.MaxValue,
            });
            result.Add(new Currency()
            {
                Name = "DOGE",
                Price = double.MaxValue,
            });
            result.Add(new Currency()
            {
                Name = "APE",
                Price = double.MaxValue,
            });
            return result;
        }
    }
}
