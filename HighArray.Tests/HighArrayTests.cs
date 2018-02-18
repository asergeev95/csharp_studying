using System;
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
        public void ShouldInsertAndFindElement()
        {
            var array = new HighArray(5);
            array.Insert(1);

            var index = array.Find(1);
            Assert.AreEqual(index, 0);

            array.Insert(2);
            index = array.Find(2);
            Assert.AreEqual(index, 1);

            var elem = array.Get(index);
            Assert.AreEqual(elem, 2);
        }

        [Test]
        public void ShouldThrowAnOutOfRangeException([Values(3, -1)] int index)
        {
            var array = new HighArray(3);

            Assert.Catch(typeof(ArgumentOutOfRangeException), () => array.Get(index));
        }

        [Test]
        public void ShouldDeleteElement()
        {
            var array = new HighArray(1);
            array.Insert(1);

            var index = array.Find(1);

            Assert.AreEqual(index, 0);

            array.Delete(1);

            Assert.Catch(() => array.Find(1), "Element not found");
            
        }

        [Test]
        public void ShouldGetMaxElement()
        {
            var array = new HighArray(2);
            array.Insert(1);
            array.Insert(2);

            var max = array.GetMax();

            Assert.AreEqual(max, 2);
        }

        [Test]
        public void ShouldDeleteMaxElement()
        {
            var array = new HighArray(2);

            array.Insert(1);
            array.Insert(2);

            var max = array.GetMax();

            Assert.AreEqual(max, 2);

            array.RemoveMax();

            max = array.GetMax();

            Assert.AreEqual(max, 1);
            
        }

        [Test]
        public void ShouldMakeSortedArray()
        {
            var fArray = new HighArray(3);

            fArray.Insert(2);
            fArray.Insert(3);
            fArray.Insert(1);

            var sArray = new HighArray(3);

            for (var i = 0; i < fArray.Length; i++)
            {
                sArray.Insert(fArray.RemoveMax());
            }

            var sArrayFirstElem = sArray.Get(0);

            Assert.AreEqual(sArrayFirstElem, 3);
        }
    }
}