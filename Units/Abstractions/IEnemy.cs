using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence.Units
{
    public interface IEnemy
    {
        int HitPoints;
        int LifeReduction;
        int CurrencyReward;
        int Speed;
    }
}
