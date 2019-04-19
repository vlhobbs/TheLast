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

            newWorld.AddLocation(1, -1, "Zoo",
                "The cages are empty, the asphalt cracked.\nBut a few robot attendants still wander about.",
                "/Engine;component/Images/Locations/Zoo.png");

            newWorld.AddLocation(0, 1, "Computer Room",
                "A room full of workstations.\nSomehow, a few machines still run.",
                "/Engine;component/Images/Locations/Servers.png");

            newWorld.AddLocation(1, 0, "Park",
                "Weeds and trees have taken over much of the place.\nThe playground equipment is overgrown.",
                "/Engine;component/Images/Locations/Park.png");

            newWorld.AddLocation(1, 1, "Hospital Lobby",
                "Torn carpet and broken chairs.\nA vending machine sits in one corner.",
                "/Engine;component/Images/Locations/Lobby.png");

            newWorld.AddLocation(1, 2, "Hospital Room",
                "A filthy hospital room. The other bed is empty.",
                "/Engine;component/Images/Locations/Hospital.png");

            newWorld.AddLocation(2, 1, "Empty Street",
                "The wind blows trash through the street.\nYou hear the constant howl of feral dogs.",
                "/Engine;component/Images/Locations/Street.png");
            newWorld.LocationAt(2, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(3, 0, "Food Court",
                "TVs and radio equipment... what was this place?\nSome sort of communication hub?",
                "/Engine;component/Images/Locations/FoodCourt.png");

            newWorld.AddLocation(3, 1, "Mall Entrance",
                "The mall building is in surprisingly good shape.\nRemnants of an old barricade sit near the door.",
                "/Engine;component/Images/Locations/Mall.png");

            newWorld.AddLocation(3, 2, "Novelty Store",
                "A few toys and knick-nacks still remain.\nSo does what is left of the store's robot security.",
                "/Engine;component/Images/Locations/Store.png");

            return newWorld;
        }
    }
}
