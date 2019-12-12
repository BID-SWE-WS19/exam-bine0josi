namespace UniTTestExam
{
    using BID.SWE.EXAM.Impl;
    using NUnit.Framework;

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
            if (this.ex3.Method1().GetType() == typeof(MyMap))
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void Method1TestIfReturnIsSomethingElse()
        {
            if (ex3.Method1().GetType() != typeof(MyMap))
            {
                Assert.IsTrue(false);
            }
            else
            {
                Assert.IsTrue(true);
            }
        }

        [Test]
        public void Method2TestIfReturnIsNotNull()
        {
            Assert.IsNotNull(ex3.Method2());
        }
    }
}
