using RPGGame.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Professions
{
    internal class Massbender : Profession
    {
        public Massbender() : base("Massbender",
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 5},
                { StatisticType.Percision, 2},
                { StatisticType.Dodge, 1},
                { StatisticType.Shape, 6},
                { StatisticType.Abstractionism, 2},
                { StatisticType.Stability, 2}
            },
            new List<Ability>
            {
                { new Ability("Healing bend", AbilityType.Eat, "Heal self value of health", 1, 1, false) },
                { new Ability("Bend body", AbilityType.Eat, "Temporary increase Shape and Strength", 1, 1, false) }
            })
        {

        }

        public Massbender(string name, List<StatisticType> statisticBoosts) : base(name,
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 5},
                { StatisticType.Percision, 2},
                { StatisticType.Dodge, 1},
                { StatisticType.Shape, 6},
                { StatisticType.Abstractionism, 2},
                { StatisticType.Stability, 2}
            },
            new List<Ability>
            {
                { new Ability("Healing bend", AbilityType.Eat, "Heal self value of health", 1, 1, false) },
                { new Ability("Bend body", AbilityType.Eat, "Temporary increase Shape and Strength", 1, 1, false) }
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
