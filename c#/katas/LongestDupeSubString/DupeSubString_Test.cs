using NUnit.Framework;

[TestFixture]
public class DupeSubString_Test
{    

    [SetUp]
    public void SetUp()
    { 
    }
    
    [Test]
    public void BananaShouldReturnANA()
    {        
        Assert.That(DupeSubstring.Longest("banana"), Is.EqualTo("ana"));
    }

    [Test]
    public void PollyShouldReturnLL()
    {
        Assert.That(DupeSubstring.Longest("polly"), Is.EqualTo("l"));
    }
     public void TexasShouldReturnEmptyString()
    {
        Assert.That(DupeSubstring.Longest("TEXAS"), Is.EqualTo("l"));
    }
}
