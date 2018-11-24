using System;
namespace Decorator
{
    public class BaseHero : IHero
    {

        public int Attack() => 100;


        public int Defend() => 100;


        public int Walk() => 100;
       
    }
}
