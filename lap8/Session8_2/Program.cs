using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8_2
{
    class IntellSenseDemo : TimeZone
    {
        public override string DaylightName
        {
            get
            {
                throw new Exception("The method operation is not imlemented.");
            }

        }
        public override System.Globalization.DaylightTimeGetDaylightChanges(int year) 
    }
}
