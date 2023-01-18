using RPGGame;
using RPGGame.Professions;
using RPGGame.Races;

Console.WriteLine("Welcome to abstract RPG game, create your character!");
Console.WriteLine("Provide name of your character:");
var name = Console.ReadLine();
Console.Clear();


Being being;
Profession profession;
List<StatisticType> professionStatBoost = new List<StatisticType>();
List<StatisticType> raceStatBoost = new List<StatisticType>();

var raceList = new List<Being>{ new Airblow(), new Brick(), new Cube(), new Lime(), new Seashell() };
var professionList = new List<Profession> { new Dimensionchanger(), new Eggeater(), new Gravitationpuller(), new Massbender(), new Professionalist() };


while (true)
{
    Console.WriteLine("Select race by picking number:");
    for(int i = 0; i < raceList.Count; i++)
    {
        Console.WriteLine($"{i}: {raceList[i].name}");
    }

    var input = Console.ReadLine();
    int raceIndex;


    if(int.TryParse(input, out raceIndex))
    {
        if(raceIndex >= 0 && raceIndex < raceList.Count)
        {
            being = raceList[raceIndex];
            break;
        }
    }
    
    Console.Clear();
    Console.WriteLine("Please select race again");
}

Console.Clear();

while (true)
{
    Console.WriteLine("Select profession by picking number:");
    for (int i = 0; i < professionList.Count; i++)
    {
        Console.WriteLine($"{i}: {professionList[i].name}");
    }

    var input = Console.ReadLine();
    int professionIndex;


    if (int.TryParse(input, out professionIndex))
    {
        if (professionIndex >= 0 && professionIndex < professionList.Count)
        {
            profession = professionList[professionIndex];
            break;
        }
    }

    Console.Clear();
    Console.WriteLine("Please select profession again");
}

Console.Clear();

var howManyBoostsOnRace = 5;
var howManyBoostsOnProfession = 5;
var enumNames = Enum.GetNames(typeof(StatisticType));
var enumValues = Enum.GetValues(typeof(StatisticType));

Console.WriteLine("Now select your race statistic bonus (you can select one multiple times):");

while (true)
{
    for (int i = 0; i < enumNames.Length; i++)
    {
        Console.WriteLine($"{i}: {enumNames[i]}");
    }

    for(int i = 0; i < howManyBoostsOnRace; i++)
    {
        var input = Console.ReadLine();
        int raceBoostIndex;

        if (int.TryParse(input, out raceBoostIndex))
        {
            if (raceBoostIndex >= 0 && raceBoostIndex <= professionList.Count)
            {
                raceStatBoost.Add((StatisticType)enumValues.GetValue(raceBoostIndex));
            }
        }
    }

    if(raceStatBoost.Count != howManyBoostsOnRace)
    {
        raceStatBoost.Clear();
        Console.Clear();
        Console.WriteLine("Please select race boosts again");
        continue;
    }

    break;
}

Console.Clear();
Console.WriteLine("Now select your profession statistic bonus (you can select one multiple times):");

while (true)
{
    for (int i = 0; i < enumNames.Length; i++)
    {
        Console.WriteLine($"{i}: {enumNames[i]}");
    }

    for (int i = 0; i < howManyBoostsOnProfession; i++)
    {
        var input = Console.ReadLine();
        int professionBoostIndex;

        if (int.TryParse(input, out professionBoostIndex))
        {
            if (professionBoostIndex >= 0 && professionBoostIndex <= professionList.Count)
            {
                professionStatBoost.Add((StatisticType)enumValues.GetValue(professionBoostIndex));
            }
        }
    }

    if(professionStatBoost.Count != howManyBoostsOnProfession)
    {
        professionStatBoost.Clear();
        Console.Clear();
        Console.WriteLine("Please select profession boosts again");
        continue;
    }

    break;
}

PlayerCharacter character = new PlayerCharacter(name, (Being)Activator.CreateInstance(being.GetType(), being.name, raceStatBoost), 
    (Profession)Activator.CreateInstance(profession.GetType(), profession.name, professionStatBoost));

Console.Clear();
Console.WriteLine("Your character card:");
Console.WriteLine($"Name:{character.name}");
Console.WriteLine($"Being:{character.being.name}");
Console.WriteLine($"Being:{character.profession.name}");
Console.WriteLine("Statistics");
foreach(StatisticType value in enumValues)
{
    Console.WriteLine($"{value}: {character.being.statistics[value] + character.profession.statistics[value]}");
}