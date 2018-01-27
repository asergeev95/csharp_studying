using NUnit.Framework;

namespace HighArray.Tests
{
    [TestFixture]
    public class HighArrayTests
    {
        [Test]
        public void ShouldCreateRandomArray()
        {
            var array = new HighArray(5);

            Assert.NotNull(array);
        }

        [Test]
        public void ShouldInsertElement()
        {
            var array = new HighArray(5);

            array.Insert(1);

            var n = array.Get(array.Find(1));

            Assert.AreEqual(n, 1);
        }
    }
}