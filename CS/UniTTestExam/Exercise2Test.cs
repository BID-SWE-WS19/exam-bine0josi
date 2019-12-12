// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
namespace UniTTestExam
{
    using BID.SWE.EXAM.Impl;
    using NUnit.Framework;

    [TestFixture]
    public class Exercise2Test
    {
        private Exercise2 ex2 = new Exercise2();

        [Test]
        public void Method2TestIfDuplicationWorks()
        {
            Assert.AreEqual(2, this.ex2.Method2());
        }

        [Test]
        public void Method2TestIfReturnValueIsNotOne()
        {
            Assert.AreNotEqual(1, this.ex2.Method2());
        }

        [Test]
        public void Method3TestIfEven()
        {
            int neighbour = 4;

            Assert.IsTrue(ex2.Method3(neighbour));
        }


        [Test]
        public void Method3TestIfNotEven()
        {
            int neighbour = 3;

            Assert.IsFalse(ex2.Method3(neighbour));
        }
    }
}
