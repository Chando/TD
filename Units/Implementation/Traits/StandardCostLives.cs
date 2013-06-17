using TowerDefence.Player;
using Units.Abstractions.Traits;

namespace Units.Implementation.Traits
{
    class StandardCostLives : ICostLives
    {
        private readonly int lifeCost;

        public StandardCostLives(int lifeCost)
        {
            this.lifeCost = lifeCost;
        }

        public void RemoveLives(Player player)
        {
            player.Lives -= lifeCost;
        }
    }
}
