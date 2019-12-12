using System;
using System.Collections.Generic;
using System.Text;

namespace BID.SWE.EXAM.Impl
{
    public class Bewegung
    {
        public string Position()
        {
            return "Cool movement";
        }

        public string Move(int x)
        {
            return $"I moved {x} step(s)!";
        }
    }
}
