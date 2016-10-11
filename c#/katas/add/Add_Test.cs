using NUnit.Framework;

namespace Katas
{
    [TestFixture]
    public class Add_Test
    {
        Add add;

        [SetUp]
        public void SetUp()
        {
            add = new Add();
        }

        [Test]
        public void ItIsAlwaysTrue()
        {
            Assert.That(add.Invoke(new [] {"2","2"}), Is.EqualTo(4));
        }

        [Test]
        public void ItIsAlwaysFalse()
        {
            var result = 4;
            Assert.That(add.Invoke(new [] {"2","3"}), !Is.EqualTo(result), $"Expected result to be not equal to {result}");
        }

        [Test]
        public void AddMoreThanTwoNumbers()
        {
            Assert.That(add.Invoke(new [] {"2","2","2"}), Is.EqualTo(6));
        }
    }
}
