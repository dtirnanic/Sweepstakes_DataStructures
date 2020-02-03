using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes sweepstakes = new Sweepstakes("baloon");

            Contestant one = new Contestant();
            Contestant two = new Contestant();
            sweepstakes.RegisterContestant(one);
            sweepstakes.RegisterContestant(two);

            sweepstakes.PickWinner();

            Console.ReadLine();

        }
    }
}
