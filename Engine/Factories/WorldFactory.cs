using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, 1, "Computer Room",
                "A room full of workstations.\nSomehow, a few machines still run.",
                "Servers.png");
            //robot quest here

            newWorld.AddLocation(1, -1, "Zoo",
                "The cages are empty, the asphalt cracked.\nBut a few robot attendants still wander about.",
                "Zoo.png");
            newWorld.LocationAt(1, -1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(1, 0, "Park",
                "Weeds and trees have taken over much of the place.\nThe playground equipment is overgrown.",
                "Park.png");

            newWorld.AddLocation(1, 1, "Hospital Lobby",
                "Torn carpet and broken chairs.\nA vending machine sits in one corner.",
                "Lobby.png");

            newWorld.AddLocation(1, 2, "Hospital Room",
                "A filthy hospital room. The other bed is empty.\nA few robots wander in and out over time.",
                "Hospital.png");

            newWorld.AddLocation(2, 1, "Empty Street",
                "The wind blows trash through the street.\nThe air is full of hissing and barking and other beastial sounds.",
                "Street.png");
            //add snakes here
            newWorld.LocationAt(2, 1).AddMonster(1, 100);

            newWorld.AddLocation(3, 0, "Food Court",
                "TVs and radio equipment... what was this place?\nSome sort of communication hub?",
                "FoodCourt.png");

            newWorld.AddLocation(3, 1, "Mall Entrance",
                "The mall building is in surprisingly good shape.\nRemnants of an old barricade sit near the door.",
                "Mall.png");

            newWorld.AddLocation(3, 2, "Novelty Store",
                "A few toys and knick-nacks still remain.\nSo does what is left of the store's robot security.",
                "Store.png");
            //add robot here
            newWorld.LocationAt(3, 2).AddMonster(3, 100);

            newWorld.AddLocation(4, 0, "Security Office",
                "Looks like there were monitors here once, but they're long gone.\nAll that's left is a broken-down robot and an unplugged fridge.",
                "Security.png");
            //add rat quest here

            newWorld.AddLocation(4, 1, "Pet Store",
                "Empty cages full of sawdust. Empty shelves.\n The constant sounds of chewing and digging in the background.",
                "PetStore.png");
            //add rats here
            newWorld.LocationAt(4, 1).AddMonster(2, 100);

            return newWorld;
        }
    }
}
