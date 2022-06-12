using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNasledovanie
{
    internal class Warrior : Unit
    {
        private int _fatigue;

        public Warrior(int i, int j, int hp, int damage,  int resistance,  int fatigue) : base(i, j, hp, damage, resistance)
        {
            _fatigue = fatigue;
        }

        public int Fatigue { get { return _fatigue; } }

        public override void Attack(Unit unit)
        {
            if (_fatigue > 0)
            {
                unit.TakeDamage(GetTotalDamage() - unit.GetTotalResistance());
                _fatigue -= 5;
                SetBuffDamage(GetBuffDamage() + 1);
            }
            else
            {
                throw new Exception("fatigue  = 0");
            }
        }
    }
}
