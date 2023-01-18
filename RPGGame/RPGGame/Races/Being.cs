using RPGGame.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Races
{
    internal class Being
    {
        public string name;
        public Dictionary<StatisticType, int> statistics;
        public List<Ability> abilities;

        public Being(string name, List<StatisticType> statisticBoosts)
        {
            this.name = name;
            statistics = new Dictionary<StatisticType, int>();
            abilities = new List<Ability>();

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
        public Being(string name, Dictionary<StatisticType, int> statistics, List<Ability> abilities)
        {
            this.name = name;
            this.statistics = statistics;
            this.abilities = abilities;
        }
    }
}
