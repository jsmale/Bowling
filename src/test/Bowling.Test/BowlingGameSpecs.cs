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

    public class WhenThrowingAlternatingSparesAndFives : BowlingGameSpecs
    {
        Establish e = () =>
        {
            throws = new int[20];
            for (int i = 0; i < throws.Length; i++)
            {
                if (i % 4 != 3)
                {
                    throws[i] = 5;
                }
            }
        };

        It ShouldHaveScoreOf100 = () => score.ShouldEqual(100);
    }

    public class WhenThrowingAlternatingSparesFivesAndTwos : BowlingGameSpecs
    {
        Establish e = () =>
        {
            throws = new int[20];
            for (int i = 0; i < throws.Length; i++)
            {
                if (i % 4 != 3)
                {
                    throws[i] = 5;
                }
                else
                {
                    throws[i] = 2;
                }
            }
        };

        It ShouldHaveScoreOf110 = () => score.ShouldEqual(110);
    }

    public class WhenThrowingAllFives : BowlingGameSpecs
    {
        Establish e = () =>
        {
            throws = new int[21];
            for (int i = 0; i < throws.Length; i++)
            {
                throws[i] = 5;
            }
        };

        It ShouldHaveScoreOf150 = () => score.ShouldEqual(150);
    }

    public class WhenAlternatingStrikesAndSpares : BowlingGameSpecs
    {
        Establish e = () =>
        {
            throws = new int[16];
            for (int i = 0; i < throws.Length; i++)
            {
                if (i % 3 == 0)
                {
                    throws[i] = 10;
                }
                else
                {
                    throws[i] = 5;
                }
            }
        };

        It ShouldHaveScoreOf200 = () => score.ShouldEqual(200);
    }
}