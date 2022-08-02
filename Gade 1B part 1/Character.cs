using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    internal class Character : Tile
    {
        protected int hp;
        protected int maxHp;
        protected int damage;

        public int HP { get { return hp; } set { hp = value; } }
        public int MaxHp { get { return maxHp; } set { maxHp = value; } }
        protected int Damage { get { return damage; } set { damage = value; } }


        public Character(int x, int y) : base(x, y)
        {

        }

        string[,] tileArray = new string[,]
        {
            {"up", "" },
            {"left", "right"},
            {"down", "" }


        };


        public enum Movement
        {
            NoMovement,
            Up,
            Down,
            Left,
            Right,
        }







    }
}
