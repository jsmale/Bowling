namespace Bowling
{
    public class BowlingGame
    {
        int total;
        private int current;
        private int last;
        private bool isFirst;
        private int totalThrows;

        public void Throw(int pins)
        {
            
            isFirst = !isFirst;
            total += pins;
            
            if (((current + last == 10  && isFirst) || current == 10 )  && totalThrows < 19)
            {
                total += pins;
            }
            if (last == 10 && totalThrows < 20)
            {
                total += pins;
            }
            if (pins == 10)
            {
                isFirst = !isFirst;
                totalThrows++;
            }
            last = current;
            current = pins;
            totalThrows ++;
        }

        public int GetScore()
        {
            return total;
        }
    }
}