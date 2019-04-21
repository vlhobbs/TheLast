using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Location
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public List<Quest> QuestsAvailableHere { get; set; } = new List<Quest>();

        public List<MonsterEncounter> MonstersHere { get; set; } =
            new List<MonsterEncounter>();

        public Trader TraderHere { get; set; }
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
