using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KarateChop.Interfaces;
using KarateChop.Classes;

namespace KarateChopTest
{
    [TestClass]
    public class ChopTest
    {
        [TestMethod]
        public void TestChopperChopExecution()
        {
            //arrage
            //act
            //assert

            //For the assertion : -1 not found , else return index

            IChopper chopper = new Chopper();

            //test against null array
            Assert.AreEqual(-1, chopper.chop(0, null));

            Assert.AreEqual(-1 , chopper.chop(3, new int[] { }));
            Assert.AreEqual(-1, chopper.chop(3, new int[] { 1 }));
            Assert.AreEqual(0, chopper.chop(1, new int[] { 1 }));
            //
            Assert.AreEqual(0, chopper.chop(1, new int[] { 1 , 3 , 5 }));
            Assert.AreEqual(1, chopper.chop(3, new int[] { 1, 3, 5 }));
            Assert.AreEqual(2, chopper.chop(5, new int[] { 1, 3, 5 }));

            
        }
    }
}
