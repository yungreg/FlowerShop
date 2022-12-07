namespace flowershop
{
    public class PinkRose : IMothersDayFlower
    {
        public string Color { get; set; }
        public int PetalCount { get; set; }
        public double StemLength { get; set; }
        public bool Thorny { get; set; }
        public override string ToString()
        {
            return $"A very cool {Color} rose with {PetalCount} petals!";
        }
    }
}