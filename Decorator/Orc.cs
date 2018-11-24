using System;
namespace Decorator
{
    public class Orc : IHero 
    {

        private IHero heroDecorated;

        public Orc(IHero heroDecorated)
        {
            this.heroDecorated = heroDecorated;
        }

        public int Attack() => heroDecorated.Attack() + 10;

        public int Defend() => heroDecorated.Defend() + 5;

        public int Walk() => heroDecorated.Walk() + 7;
    }
}
