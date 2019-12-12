using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    /// <summary>
    ///  eigene Klasse davon, Methode überschreiben (grow)
    /// </summary>
    /// <seealso cref="BID.SWE1.Exam.Interfaces.IExercise2" />
    public class Exercise2 : IExercise2
    {
        public object Method1()
        {
            return new MyCell();
        }

        public int Method2()
        {
            return new MyCell2().Grow();
        }

        public bool Method3(int o1)
        {
            return new MyCell3().IsAlive(o1);
        }
    }
}