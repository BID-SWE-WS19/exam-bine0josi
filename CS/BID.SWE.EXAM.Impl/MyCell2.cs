using BID.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BID.SWE.EXAM.Impl
{
    public class MyCell2 : Cell
    {
        public override int Grow()
        {
            return this._size * 2;
        }
    }
}
