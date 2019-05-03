using Engine.Factories;
using System.Collections.Generic;
using System.Linq;

namespace Engine.Models
{
    public class Location
    {
        public int XCoordinate { get; }
        public int YCoordinate { get; }
        public string Name { get; }
        public string Description { get; }
        public string ImageName { get;}

        public List<Quest> QuestsAvailableHere { get; set; } = new List<Quest>();

        public List<MonsterEncounter> MonstersHere { get; } =
            new List<MonsterEncounter>();

        public Trader TraderHere { get; set; }

        public Location(int xCoordinate, int yCoordinate, string name, string description, string imageName)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            Name = name;
            Description = description;
            ImageName = imageName;
        }

        public void AddMonster(int monsterID, int chanceOfEncountering)
        {
            if(MonstersHere.Exists(m => m.MonsterID == monsterID))
            {
                // if this monster is already in list:
                // overwrite ChanceOfEncountering with new value
                MonstersHere.First(m => m.MonsterID == monsterID)
                    .ChanceOfEncountering = chanceOfEncountering;
            }
            else
            {
                // otherwise add to list
                MonstersHere.Add(new MonsterEncounter(monsterID, chanceOfEncountering));
            }
        }

        public Monster GetMonster()
        {
            if(!MonstersHere.Any())
            {
                return null;
            }

            //Total percentages of all monster encounter chances here
            int totalChances = MonstersHere.Sum(m => m.ChanceOfEncountering);

            //select random number between 1 and total
            int randomNumber = RandomNumberGenerator.NumberBetween(1, totalChances);

            //Iterate through monster list
            //Create a running total of monster percentages
            //Once the random number < running total
            //return the monster iterator is currently on
            int runningTotal = 0;

            foreach(MonsterEncounter monsterEncounter in MonstersHere)
            {
                runningTotal += monsterEncounter.ChanceOfEncountering;

                if (randomNumber <= runningTotal)
                {
                    return MonsterFactory.GetMonster(monsterEncounter.MonsterID);
                }
            }

            //If something happened then return the last monster in the list
            return MonsterFactory.GetMonster(MonstersHere.Last().MonsterID);
        }
    }
}
/*The way I'm reading this now, there is a 100% chance of encountering a monster no matter what the number actually is
 * Is there a way to set it to less than that so that
 * you aren't necessarily fighting when there is a monster there?
 */