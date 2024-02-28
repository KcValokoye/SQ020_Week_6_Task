using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ20.Net_Week6_Task
{
    public class StateHelper
    {
        public static IEnumerable<string> SplitStatesIntoGroups(IEnumerable<string> states, int groupSize)
        {
            return states.Select((state, index) => new { state, index })
                .GroupBy(x => x.index / groupSize)
                .Select(grp => string.Join(", ", grp.Select(x => x.state)));
        }
    }
}