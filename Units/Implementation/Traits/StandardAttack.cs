using Units.Abstractions;
using Units.Abstractions.Traits;

namespace Units.Implementation.Traits
{
    public class StandardAttack : IAttack
    {
        private readonly int attackDamage;

        public StandardAttack(int attackDamage)
        {
            this.attackDamage = attackDamage;
        }

        public void DealDamage(IEnemy enemy)
        {
            enemy.HitPoints -= this.attackDamage;
        }
    }
}
