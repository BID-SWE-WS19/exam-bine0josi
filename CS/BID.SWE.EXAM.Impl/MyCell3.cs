using BID.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BID.SWE.EXAM.Impl
{
    public class MyCell3 : Cell
    {
        public bool IsAlive(int neighbour)
        {
            if (neighbour%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
