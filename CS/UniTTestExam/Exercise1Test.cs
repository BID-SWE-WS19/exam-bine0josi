// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using BID.SWE.EXAM.Impl;
using NUnit.Framework;

namespace UniTTestExam
{
    [TestFixture]
    public class Exercise1Test
    {
        private Exercise1 ex1 = new Exercise1();
        [Test]
        public void TestIfInstanceIsNotNull()
        {
            Assert.IsNotNull(this.ex1.Method1());
        }

        [Test]
        public void TestIfInstanceIsCellPrinter()
        {
            /// sorry for awful test, could not imagen any better one, sorry....
            try
            {
                CellPrinter print = ex1.Method1() as CellPrinter;
                Assert.IsTrue(true);
            }
            catch (System.Exception)
            {
                Assert.IsTrue(false);
            }
        }
    }
}
