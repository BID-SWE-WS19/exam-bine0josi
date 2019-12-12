using BID.SWE.EXAM.Impl;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniTTestExam
{
    [TestFixture]
    class Exercise3Test
    {
        private Exercise3 ex3 = new Exercise3();

        [Test]
        public void Method1TestIfReturnIsNotNull()
        {
            Assert.IsNotNull(ex3.Method1());
        }

        [Test]
        public void Method1TestIfReturnIsMyMap()
        {
            try
            {
                MyMap print = ex3.Method1() as MyMap;
                Assert.IsTrue(true);
            }
            catch (System.Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void Method1TestIfReturnIsSomethingElse()
        {
            try
            {
                CellPrinter print = ex3.Method1() as CellPrinter;
                Assert.IsTrue(false);
            }
            catch (System.Exception)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
