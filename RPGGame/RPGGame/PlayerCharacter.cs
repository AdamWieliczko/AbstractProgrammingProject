using RPGGame.Professions;
using RPGGame.Races;

namespace RPGGame
{
    internal class PlayerCharacter: IPlayerCharacter
    {
        public string name;
        public Being being;
        public Profession profession;

        public PlayerCharacter(string name) 
        {
            this.name = name;
        }

        public PlayerCharacter(string name, Being being, Profession profession)
        {
            this.name = name;
            this.being = being;
            this.profession = profession;
        }
    }
}
