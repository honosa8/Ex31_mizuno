using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    internal class Hornet: Animal
    {
        public Hornet(string name, float hp, float power)
            : base(name, hp, power)
        {

        }

        public override void Attack(Character destination)
        {
            if (destination is Animal)
            {
                Console.WriteLine($"{this.name}は{destination.name}を毒針で刺した！");
                Console.WriteLine($"{destination.name}は動物だ！");
                Console.WriteLine($"{destination.name}は即死した！");
            }
            else
            {
                Console.WriteLine($"{this.name}は{destination.name}を毒針で刺した！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
        }
    }
}
