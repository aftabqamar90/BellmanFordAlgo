namespace BellmanFordAlgo.Models
{
    public class Edges
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Key => $"{Destination}{Source}";
        public double Weight { get; set; }
        public double Price { get; set; }
    }
}
