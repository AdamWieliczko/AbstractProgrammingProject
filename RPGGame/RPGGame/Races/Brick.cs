using RPGGame.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Races
{
    internal class Brick : Being
    {
        public Brick() : base("Brick",
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 6},
                { StatisticType.Percision, 1},
                { StatisticType.Dodge, 1},
                { StatisticType.Shape, 6},
                { StatisticType.Abstractionism, 2},
                { StatisticType.Stability, 2}
            },
            new List<Ability>
            {
            })
        {

        }

        public Brick(string name, List<StatisticType> statisticBoosts) : base(name,
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 6},
                { StatisticType.Percision, 1},
                { StatisticType.Dodge, 1},
                { StatisticType.Shape, 6},
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
