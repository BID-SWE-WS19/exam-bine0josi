namespace BID.SWE.EXAM.Impl
{
    using BID.SWE1.Exam.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CellPrinter : ICellPrinter
    {
        public string PrintPostion(int x, int y)
        {
            return $"Cell is on Position X:{x} Y:{y}";
        }

        public string PrintState(bool alive, DateTime date, string color)
        {
            return $"Cell {color} born on {date} is alive";
        }
    }
}
