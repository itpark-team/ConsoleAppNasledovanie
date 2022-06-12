using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNasledovanie
{
    internal abstract class Unit
    {
        private int _i, _j;
        private int _hp;
        private int _damage;
        private int _resistance;

        private int _buffDamage;
        private int _buffResistance;

        protected Unit(int i, int j, int hp, int damage, int resistance)
        {
            _i = i;
            _j = j;
            _hp = hp;
            _damage = damage;
            _resistance = resistance;

            _buffDamage = 0;
            _buffResistance = 0;
        }

        public int I { get { return _i; } }
        public int J { get { return _j; } }
        public int HP { get { return _hp; } }
        public int Damage { get { return _damage; } }

        public void SetBuffDamage(int buff)
        {
            _buffDamage = buff;
        }

        public int GetBuffDamage()
        {
            return _buffDamage;
        }

        public void SetBuffResistance(int buff)
        {
            _buffResistance = buff;
        }

        public int GetBuffResistance()
        {
            return _buffResistance;
        }

        public int GetResistance()
        {
            return _resistance;
        }

        public int GetDamage()
        {
            return _damage;
        }

        public int GetTotalDamage()
        {
            return GetDamage() + GetBuffDamage();
        }

        public int GetTotalResistance()
        {
            return GetResistance() + GetBuffResistance();
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0) { damage = 0; }

            _hp -= damage;
        }

        public abstract void Attack(Unit unit);
    }
}
