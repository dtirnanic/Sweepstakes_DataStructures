using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Simulation
    {

        public void CreateMarketingFirmWithManager()
        {
            int choice = Int32.Parse(Userinterface.GetUserInputFor("Enter 1 for stack manager, enter 2 for queue manager."));
            ISweepstakesManager manager;
            
            if (choice == 1)
            {
                manager = new SweepstakesStackManager();
            }
            else 
            {
                manager = new SweepstakesQueueManager();
            }
          
            MarketingFirm marketingFirm = new MarketingFirm(manager);
        }

    }
}
