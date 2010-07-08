namespace Bowling
{
    public class BowlingGame
    {
        int total;
        private int current;
        private int last;

        public void Throw(int pins)
        {            
            total += pins;
            if (current + last == 10)
            {
                total += pins;
            }
            last = current;
            current = pins;
        }

        public int GetScore()
        {
            return total;
        }
    }
}