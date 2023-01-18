﻿using RPGGame.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Races
{
    internal class Seashell : Being
    {
        public Seashell() : base("Seashell",
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 1},
                { StatisticType.Percision, 3},
                { StatisticType.Dodge, 3},
                { StatisticType.Shape, 1},
                { StatisticType.Abstractionism, 5},
                { StatisticType.Stability, 5}
            },
            new List<Ability>
            {
            })
        {

        }

        public Seashell(string name, List<StatisticType> statisticBoosts) : base(name,
            new Dictionary<StatisticType, int>
            {
                { StatisticType.Strength, 1},
                { StatisticType.Percision, 3},
                { StatisticType.Dodge, 3},
                { StatisticType.Shape, 1},
                { StatisticType.Abstractionism, 5},
                { StatisticType.Stability, 5}
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
