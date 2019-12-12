using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise3 : IExercise3
    {
        public object Method1()
        {
            return new MyMap();
        }

        public object Method2()
        {
            /// zwei klassen eine überklasse 
            Bewegung[] bewegung = new Bewegung[2];

            bewegung[0] = new Laufen();
            bewegung[1] = new Springen();

            return bewegung;
        }

    }
}