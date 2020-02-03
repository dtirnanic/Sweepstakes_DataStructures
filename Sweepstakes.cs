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
        int registrationNumber = 0;

        public Sweepstakes(string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant) 
        {
            registrationNumber++;
            contestant.registrationNumber = registrationNumber;
            contestants.Add(registrationNumber,contestant);
        }

        public Contestant PickWinner()
        {
            Random random = new Random();
            int winner = random.Next(1, registrationNumber);
            Contestant winningContestant;
            contestants.TryGetValue(winner, out winningContestant);
            return winningContestant;
            
            
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"{contestant.firstName} {contestant.lastName} {contestant.emailAddress} {contestant.registrationNumber}");
        }
    }
}
