namespace Engine.Models
{
    public class Monster : LivingEntity
    {
        public string ImageName { get;}

        public int RewardExperiencePoints { get; }

        public Monster(string name, string imageName,
            int maximumHitPoints, int currentHitPoints,
            int rewardExperiencePoints, int tokens) :
        base(name, maximumHitPoints, currentHitPoints, tokens)
        {
            ImageName = $"/Engine;component/Images/Monsters/{imageName}";
            RewardExperiencePoints = rewardExperiencePoints;
        }
    }
}
