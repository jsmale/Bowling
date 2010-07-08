using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;

namespace Bowling.Test
{
    public abstract class BowlingGameSpecs : Observes<BowlingGame>
    {
        Because b = () =>
        {
            foreach (var @throw in throws)
            {
                sut.Throw(@throw);
            }
            score = sut.GetScore();
        };
        
        public static int[] throws;
        public static int score;
    }

    public class WhenThrowingAllGutters : BowlingGameSpecs
    {
        Establish e = () =>
        {
            throws = new int[20];
        };

        It ShouldHaveScoreOfZero = () => score.ShouldEqual(0);
    }

    public class WhenThrowingAllOnes : BowlingGameSpecs
    {
        Establish e = () =>
        {
            throws = new int[20];
            for (int i = 0; i < throws.Length; i++)
            {
                throws[i] = 1;
            }
        };

        It ShouldHaveScoreOf20 = () => score.ShouldEqual(20);
    }
}