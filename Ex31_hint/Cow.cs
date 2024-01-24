using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    internal class Cow:Animal
    {
        public Cow(string name, float hp, float power)
            : base(name, hp, power) 
        {
            
        }

        public override void Attack(Character destination)
        {
            if (destination.hp >= 5)
            {
                Console.WriteLine($"{this.name}は{destination.name}を角で突いた！");
                Console.WriteLine($"{destination.name}に穴が空いた！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{this.name}は攻撃するほどの体力がなかった");
            }
        }
    }
}
