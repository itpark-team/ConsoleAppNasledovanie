using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNasledovanie
{
    internal class Archer : Unit
    {
        private int _countArrows = 10;

        public Archer(int i, int j, int hp, int damage, int resistance, int countArrows) : base(i, j, hp, damage, resistance)
        {
            _countArrows = countArrows;
        }

        public override void Attack(Unit unit)
        {
            if (_countArrows > 0)
            {
                unit.TakeDamage(GetTotalDamage() - unit.GetTotalResistance());
                _countArrows--;
            }
            else
            {
                throw new Exception("count arrows  = 0");
            }
        }
    }
}
