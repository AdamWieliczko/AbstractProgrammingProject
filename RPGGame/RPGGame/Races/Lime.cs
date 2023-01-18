using RPGGame.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Races
{
    internal class Lime : Being
    {
        public Lime() : base("Lime",
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 4},
                { StatisticType.Percision, 4},
                { StatisticType.Dodge, 4},
                { StatisticType.Shape, 2},
                { StatisticType.Abstractionism, 2},
                { StatisticType.Stability, 2}
            },
            new List<Ability>
            {
            })
        {

        }

        public Lime(string name, List<StatisticType> statisticBoosts) : base(name,
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 4},
                { StatisticType.Percision, 4},
                { StatisticType.Dodge, 4},
                { StatisticType.Shape, 2},
                { StatisticType.Abstractionism, 2},
                { StatisticType.Stability, 2}
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
