using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Abilities
{
    internal class Ability
    {
        private string _name;
        private AbilityType _type;
        private string _description;
        private int _level;
        private int _value;
        private bool _isAbilityPassive;

        public Ability(string name, AbilityType type, string description, int level, int value, bool isPassive)
        {
            _name = name; 
            _type = type;
            _description = description;
            _level = level;
            _value = value;
            _isAbilityPassive = isPassive;
        }

        public void ChangeAbility(string name, AbilityType type, string description, int level, int value, bool isPassive)
        {
            _name = name;
            _type = type;
            _description = description;
            _level = level;
            _value = value;
            _isAbilityPassive = isPassive;
        }

        public string GetName()
        {
            return _name;
        }

        public AbilityType GetType()
        {
            return _type;
        }

        public string GetDescription()
        {
            return _description;
        }

        public int GetLevel()
        {
            return _level;
        }

        public int GetValue()
        {
            return _value;
        }

        public bool IsPassive()
        {
            return _isAbilityPassive;
        }

        public int CastAbility()
        {
            return 0;
        }
    }
}
