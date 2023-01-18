using RPGGame.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Races
{
    internal class Airblow: Being
    {
        public Airblow() : base("Airblow",
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 3},
                { StatisticType.Percision, 3},
                { StatisticType.Dodge, 6},
                { StatisticType.Shape, 1},
                { StatisticType.Abstractionism, 4},
                { StatisticType.Stability, 1}
            },
            new List<Ability>
            {
            })
        { 

        }

        public Airblow(string name, List<StatisticType> statisticBoosts) : base(name,
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 3},
                { StatisticType.Percision, 3},
                { StatisticType.Dodge, 6},
                { StatisticType.Shape, 1},
                { StatisticType.Abstractionism, 4},
                { StatisticType.Stability, 1}
            },
            new List<Ability>
            {
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
