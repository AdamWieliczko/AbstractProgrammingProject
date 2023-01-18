using RPGGame.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Professions
{
    internal class Eggeater: Profession
    {
        public Eggeater() : base("Eggeater",
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 1},
                { StatisticType.Percision, 2},
                { StatisticType.Dodge, 2},
                { StatisticType.Shape, 1},
                { StatisticType.Abstractionism, 6},
                { StatisticType.Stability, 6}
            },
            new List<Ability>
            {
                { new Ability("Egg", AbilityType.Gravitation, "Heal target for value health", 1, 4, false) },
                { new Ability("Speed up", AbilityType.Gravitation, "Increase targets dodge by value for value turns", 1, 2, false) }
            })
        {

        }

        public Eggeater(string name, List<StatisticType> statisticBoosts) : base(name,
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 1},
                { StatisticType.Percision, 2},
                { StatisticType.Dodge, 2},
                { StatisticType.Shape, 1},
                { StatisticType.Abstractionism, 6},
                { StatisticType.Stability, 6}
            },
            new List<Ability>
            {
                { new Ability("Egg", AbilityType.Gravitation, "Heal target for value health", 1, 4, false) },
                { new Ability("Speed up", AbilityType.Gravitation, "Increase targets dodge by value for value turns", 1, 2, false) }
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
