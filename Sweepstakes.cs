using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int,Contestant> contestants = new Dictionary<int,Contestant>();

        string name { get; set; }

        public Sweepstakes(string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant) 
        {
            contestants.Add(contestant.registrationNumber,contestant);
        }

        public Contestant PickWinner()
        {
            Random random = new Random();
            
            
        }

        public void PrintContestantInfo(Contestant contestant)
        {

            Console.WriteLine($"{contestant.firstName} {contestant.lastName} {contestant.emailAddress} {contestant.registrationNumber}");

        }
    }
}
