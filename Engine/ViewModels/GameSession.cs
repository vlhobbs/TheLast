using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; } 


        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Scott";
            CurrentPlayer.CharacterClass = "Cyborg";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Tokens = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Hospital Room";
            CurrentLocation.XCoordinate = 1;
            CurrentLocation.YCoordinate = 2;
            CurrentLocation.Description = "A filthy hospital room. The other bed is empty.";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/Hospital.png";
        }
    }
}
