using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ20.Net_Week6_Task
{
    public class StateCounter
    {
        public void CountStates(IEnumerable<string> states)
        {
            var groups = states.GroupBy(s => s[0])
                .OrderBy(g => g.Key)
                .Select((g, index) => new { GroupName = $"Group {(char)('A' + index)}", Count = g.Count() });

            foreach (var group in groups)
            {
                Console.WriteLine($"{group.GroupName} - {group.Count}");
                Console.WriteLine("-------------------------");
                foreach (var state in states.Where(s => s.StartsWith(group.GroupName.Substring(6))))
                {
                    Console.WriteLine(state);
                }
                Console.WriteLine();
            }

        }


    }
}