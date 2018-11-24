using System;
namespace Decorator
{
    public class Elf : IHero
    {
        private IHero heroDecorated;


        public Elf(IHero heroDecorated)
        {
            this.heroDecorated = heroDecorated;
        }

        public int Attack() => heroDecorated.Attack() + 40;

        public int Defend() => heroDecorated.Defend() + 30;

        public int Walk() => heroDecorated.Walk() + 50;
  
    }
}
