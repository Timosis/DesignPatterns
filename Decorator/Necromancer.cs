using System;
namespace Decorator
{
    public class Necromancer : IHero
    {

        private IHero heroDecorated;
        
        public Necromancer(IHero heroDecorated)
        {
            this.heroDecorated = heroDecorated;
        }

        public int Attack() => heroDecorated.Attack() + 40;

        public int Defend() => heroDecorated.Defend() + 20;

        public int Walk() => heroDecorated.Walk() + 10;

    }
}
