using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IHero hero = new BaseHero();
            Console.WriteLine("Hero Attack:{0}", hero.Attack());
            Console.WriteLine("Hero Defend:{0}", hero.Defend());
            Console.WriteLine("Hero Defend:{0}\n", hero.Walk());


            Elf elf = new Elf(hero);
            Console.WriteLine("Elf Attack:{0}", elf.Attack());
            Console.WriteLine("Elf Defend:{0}", elf.Defend());
            Console.WriteLine("Elf Defend:{0}\n", elf.Walk());

            Necromancer necromancer = new Necromancer(hero);
            Console.WriteLine("Necromancer Attack:{0}", necromancer.Attack());
            Console.WriteLine("Necromancer Defend:{0}", necromancer.Defend());
            Console.WriteLine("Necromancer Defend:{0}\n", necromancer.Walk());

            Orc orc = new Orc(hero);
            Console.WriteLine("Orc Attack:{0}", orc.Attack());
            Console.WriteLine("Orc Defend:{0}", orc.Defend());
            Console.WriteLine("Orc Defend:{0}\n", orc.Walk());

        }
    }
}
