using RPGGame.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Professions
{
    internal class Professionalist: Profession
    {
        public Professionalist() : base("Professionalist",
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 3},
                { StatisticType.Percision, 3},
                { StatisticType.Dodge, 3},
                { StatisticType.Shape, 3},
                { StatisticType.Abstractionism, 3},
                { StatisticType.Stability, 3}
            },
            new List<Ability>
            {
                { new Ability("Good looking", AbilityType.Disturb, "Enemy have percision debuff when attacking this unit", 1, 2, true) }
            })
        {

        }

        public Professionalist(string name, List<StatisticType> statisticBoosts) : base(name,
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 3},
                { StatisticType.Percision, 3},
                { StatisticType.Dodge, 3},
                { StatisticType.Shape, 3},
                { StatisticType.Abstractionism, 3},
                { StatisticType.Stability, 3}
            },
            new List<Ability>
            {
                { new Ability("Good looking", AbilityType.Disturb, "Enemy have percision debuff when attacking this unit", 1, 2, true) }
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
