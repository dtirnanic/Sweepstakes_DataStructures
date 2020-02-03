using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        ISweepstakesManager _manager;


        public MarketingFirm(ISweepstakesManager manager)
        {
            this._manager = manager;
        }

        public void CreateSweepstakes()
        {
            string name = Userinterface.GetUserInputFor("name sweepstakes");
            Sweepstakes sweepstakes = new Sweepstakes(name);
            _manager.InsertSweepstakes(sweepstakes);
        }


           

    }
}
