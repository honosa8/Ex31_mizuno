using System;

namespace Ex31_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("しむら人", 500, 2);
            Character character2 = new Character("ささっき", 1000, 25);
            Tank tank1 = new Tank("Tiger", 500000, 250);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125);
            tank2.bullet = 5;
            Cow cow = new Cow("牛鬼", 2000, 50000);
            Cat cat = new Cat("キャスパリーグ", 300000, 4000);
            Hornet hornet = new Hornet("スズメバチ", 1000000, 20);
            Character[] characters = { character1, character2, tank1, tank2 };
            /*for(var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
            }*/
            cow.Attack(hornet);
            cat.Attack(hornet);
            hornet.Attack(cat);
            hornet.Attack(character1);
        }
    }
}
