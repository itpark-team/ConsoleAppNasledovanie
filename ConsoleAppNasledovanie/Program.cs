using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNasledovanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Unit warrior = new Warrior();
            Archer archer = new Archer();

            warrior.Attack(archer);

            archer.Attack(warrior);

            archer.Attack(archer);*/

            //(warrior as Warrior).SupperAttack(warrior);
            //((Warrior)warrior).SupperAttack();

            /*Shape[] shapes = new Shape[]
            {
                new Circle(),
                new Rectangle(),
                new Circle()
            };

            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Draw();
            }*/

            Warrior warrior = new Warrior(0, 0, 10, 3, 2, 15);
            Archer archer = new Archer(0, 0, 10, 2, 0, 10);

            warrior.SetBuffDamage(5);

            archer.SetBuffResistance(6);

            warrior.Attack(archer);

            Console.WriteLine(archer.HP);

            Console.ReadKey();
        }
    }
}
