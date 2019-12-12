
namespace UniTTestExam
{
    using BID.SWE.EXAM.Impl;
    using NUnit.Framework;
    using System;
    using System.IO;

    [TestFixture]
    public class Exercise4Test
    {
        private Exercise4 ex4 = new Exercise4();

        [Test]
        public void Method1TestIfReturnValueIsNotNull()
        {
            Assert.IsNotNull(ex4.Method1());
        }


        [Test]
        public void Method2TestIfStringIsCorrect()
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);

            writer.Write("Hallo");

            writer.Close();

            Assert.IsNotNull(ex4.Method2(stream));
        }
    }
}
