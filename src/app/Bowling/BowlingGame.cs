namespace Bowling
{
    public class BowlingGame
    {
        int total;

        public void Throw(int pins)
        {
            total += pins;
        }

        public int GetScore()
        {
            return total;
        }
    }
}