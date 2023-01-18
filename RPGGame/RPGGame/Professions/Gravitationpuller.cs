using RPGGame.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Professions
{
    internal class Gravitationpuller: Profession
    {
        public Gravitationpuller() : base("Gravitationpuller",
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 2},
                { StatisticType.Percision, 3},
                { StatisticType.Dodge, 2},
                { StatisticType.Shape, 1},
                { StatisticType.Abstractionism, 5},
                { StatisticType.Stability, 5}
            },
            new List<Ability>
            {
                { new Ability("Gravitation pull", AbilityType.Gravitation, "Moves target given number of rows and deals damage equal to moved distance", 1, 2, false) },
                { new Ability("Slow", AbilityType.Gravitation, "Target moves value slower", 1, 3, false) }
            })
        {

        }

        public Gravitationpuller(string name, List<StatisticType> statisticBoosts) : base(name,
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 2},
                { StatisticType.Percision, 3},
                { StatisticType.Dodge, 2},
                { StatisticType.Shape, 1},
                { StatisticType.Abstractionism, 5},
                { StatisticType.Stability, 5}
            },
            new List<Ability>
            {
                { new Ability("Gravitation pull", AbilityType.Gravitation, "Moves target given number of rows and deals damage equal to moved distance", 1, 2, false) },
                { new Ability("Slow", AbilityType.Gravitation, "Target moves value slower", 1, 3, false) }
            })
        {
            foreach (var statistic in statisticBoosts)
                if (statistics.ContainsKey(statistic))
                {
                    statistics[statistic] += 1;
                }
                else
                {
                    statistics.Add(statistic, 1);
                }
        }
    }
}
