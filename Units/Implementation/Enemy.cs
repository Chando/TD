using TowerDefence.Player;
using Units.Abstractions;
using Units.Abstractions.Traits;

namespace Units.Implementation
{
    public class Enemy : IEnemy
    {
        private readonly IAttack attackBehaviour;
        private readonly ICostLives costLivesBehaviour;
        private readonly IReward rewardBehaviour;

        public Enemy(IAttack attackBehaviour, ICostLives costLivesBehaviour, IReward rewardBehaviour)
        {
            this.attackBehaviour = attackBehaviour;
            this.costLivesBehaviour = costLivesBehaviour;
            this.rewardBehaviour = rewardBehaviour;
        }

        public void DealDamage(IEnemy enemy)
        {
            this.attackBehaviour.DealDamage(enemy);
        }

        public void RemoveLives(Player player)
        {
            this.costLivesBehaviour.RemoveLives(player);
        }

        public void GiveReward(Player player)
        {
            this.rewardBehaviour.GiveReward(player);
        }
    }
}
