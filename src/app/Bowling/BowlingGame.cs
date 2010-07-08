namespace Bowling
{
    public class BowlingGame
    {
        private int Total { get; set; }

        public void Throw(int pins)
        {
            Total += pins;
        }

        public int GetScore()
        {
            return Total;
        }
    }
}