using NUnit.Framework;

[TestFixture]
public class BowlingGame_Test
{
    private Game g;

    [SetUp]
    public void SetUp()
    {
        g = new Game();
    }

    private void RollMany(int rolls, int pins)
    {
        for (int i = 0; i < rolls; i++)
        {
            g.Roll(pins);
        }
    }

    [Test]
    public void GutterGame()
    {
        RollMany(20, 0);
        Assert.That(g.Score(), Is.EqualTo(0));
    }

    [Test]
    public void AllOnesGame()
    {
        RollMany(20, 1);
        Assert.That(g.Score(), Is.EqualTo(20));
    }

    [Test]
    public void OneSpare()
    {
        RollSpare();
        g.Roll(3);
        RollMany(17, 0);

        Assert.That(g.Score(), Is.EqualTo(16));
    }

    [Test]
    public void OneStrike()
    {
        RollStrike();
        g.Roll(3);
        g.Roll(4);
        RollMany(16, 0);

        Assert.That(g.Score(), Is.EqualTo(24));
    }

    [Test]
    public void PerfectGame()
    {
        RollMany(21, 10);

        Assert.That(g.Score(), Is.EqualTo(300));
    }

    private void RollStrike()
    {
        g.Roll(10);
    }

    private void RollSpare()
    {
        g.Roll(5);
        g.Roll(5);
    }
}
