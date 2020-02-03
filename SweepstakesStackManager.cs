﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            if (stack.Count > 0)
            {
                return stack.Pop();
            }
            else
            {
                return null;
            }


            
           
        }
    }
}
