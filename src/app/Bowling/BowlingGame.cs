namespace Bowling
{
    public class BowlingGame
    {
        int total;
        private int current;
        private int last;
        private bool isFirst;

        public void Throw(int pins)
        {
            isFirst = !isFirst;
            total += pins;
            if (current + last == 10 && isFirst)
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