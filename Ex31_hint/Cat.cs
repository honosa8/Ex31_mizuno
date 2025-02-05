﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    internal class Cat:Animal
    {
        public Cat(string name, float hp, float power)
            : base(name, hp, power)
        {

        }

        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}をひっかいた！");
            Console.WriteLine($"{destination.name}は出血状態になった");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
            destination.hp -= this.power;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}
