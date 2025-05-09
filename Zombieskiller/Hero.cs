using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zombieskiller.AttackBehaviors;

#nullable disable
namespace Zombieskiller
{
    public class Hero
    {
        private static Hero _instance;
        private IAttackStrategy _strategy;
        private Hero(IAttackStrategy initialStrategy)
        {
            _strategy = initialStrategy;
        }
        public static Hero Instance(IAttackStrategy initialStrategy = null)
        {
            if (_instance == null)
            {
                if (initialStrategy == null)
                {
                    throw new InvalidOperationException("Initial strategy must be provided when creating the Hero for the first time.");
                }
                _instance = new Hero(initialStrategy);
            }
            return _instance;
        }

        public void ChangeAttackStyle(IAttackStrategy newStrategy)
        {
            _strategy = newStrategy;
            Console.WriteLine("🎯 Attack strategy changed!");
        }

        public void Attack()
        {
            if (_strategy == null)
                Console.WriteLine("⚠️ No attack strategy selected!");
            else
                _strategy.Attack();
        }

    }
}