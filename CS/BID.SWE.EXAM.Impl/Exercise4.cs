using System;
using System.IO;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise4 : IExercise4
    {
        public object Method1()
        {
            MemoryStream stream = new MemoryStream();
            //byte stream
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(" Frohe Weihnachten ");
            writer.Write(42);
            writer.Write(false);
            writer.Close();

            return stream;
        }

        public object Method2(object obj)
        {
            MemoryStream stream = 
        }
    }
}