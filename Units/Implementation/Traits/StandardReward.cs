using TowerDefence.Player;
using Units.Abstractions.Traits;

namespace Units.Implementation.Traits
{
    class StandardReward : IReward
    {
        private readonly int reward;

        public StandardReward(int reward)
        {
            this.reward = reward;
        }

        public void GiveReward(Player player)
        {
            player.Money += this.reward;
        }
    }
}
