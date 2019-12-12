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
            if (ex1.Method1().GetType() == typeof(CellPrinter))
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
