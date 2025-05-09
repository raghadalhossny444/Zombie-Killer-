using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zombieskiller.AttackBehaviors
{
    public class MeleeAttack : IAttackStrategy
    {

        public void Attack (){
            Console.WriteLine ("🗡️ Attacking with melee weapon!");
        }
        
    }
}