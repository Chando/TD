using Units.Abstractions;
using Units.Abstractions.Traits;
using Units.Implementation.Traits;

namespace Units.Implementation
{
    class EnemyFactory
    {
        public IEnemy GetStandardEnemy()
        {
            var result = new Enemy
                (
                    this.GetStandardAttackStrategy(10),//SA - Would be nice to have this in a seperate settings file, XML?
                    this.GetStandardCostLives(1),
                    this.GetStandardReward(10)
                );
            return result;
        }

        protected IAttack GetStandardAttackStrategy(int attackDamage)
        {
            return  new StandardAttack(attackDamage);
        }

        protected ICostLives GetStandardCostLives(int lifeCost)
        {
            return  new StandardCostLives(lifeCost);
        }

        protected IReward GetStandardReward(int rewardAmount)
        {
            return new StandardReward(rewardAmount);
        }

    }
}
