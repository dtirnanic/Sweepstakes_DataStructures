using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        public Contestant()
        {
            firstName = Userinterface.GetUserInputFor("Get contestant first name.");
            lastName = Userinterface.GetUserInputFor("Get contestant last name.");
            emailAddress = Userinterface.GetUserInputFor("Get contestant email address.");
            registrationNumber = Int32.Parse(Userinterface.GetUserInputFor("Enter contestant registration number."));
        }

        
    }
    
}
