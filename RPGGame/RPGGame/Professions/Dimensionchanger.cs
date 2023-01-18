using RPGGame.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Professions
{
    internal class Dimensionchanger: Profession
    {
        public Dimensionchanger() : base("Dimensionchanger",
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 3},
                { StatisticType.Percision, 5},
                { StatisticType.Dodge, 5},
                { StatisticType.Shape, 1},
                { StatisticType.Abstractionism, 2},
                { StatisticType.Stability, 2}
            },
            new List<Ability>
            {
                { new Ability("Dimension swap", AbilityType.Eat, "You become immune to all damage but only action you can take is to walk or remove this spell", 1, 3, false) },
                { new Ability("One on one", AbilityType.Bean, "If you and your target don't have any unit nearby you deal extra value bean damage", 1, 2, true) }
            })
        {

        }

        public Dimensionchanger(string name, List<StatisticType> statisticBoosts) : base(name,
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 3},
                { StatisticType.Percision, 5},
                { StatisticType.Dodge, 5},
                { StatisticType.Shape, 1},
                { StatisticType.Abstractionism, 2},
                { StatisticType.Stability, 2}
            },
            new List<Ability>
            {
                { new Ability("Dimension swap", AbilityType.Eat, "You become immune to all damage but only action you can take is to walk or remove this spell", 1, 3, false) },
                { new Ability("One on one", AbilityType.Bean, "If you and your target don't have any unit nearby you deal extra value bean damage", 1, 2, true) }
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
