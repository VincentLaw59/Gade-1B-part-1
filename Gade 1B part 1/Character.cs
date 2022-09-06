using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    internal abstract class Character : Tile
    {
        protected int hp;
        protected int maxHp;
        protected int damage;
        protected char c = (char)208;
        protected bool isDead;

        public int HP { get { return hp; } set { hp = value; } }
        public int MaxHp { get { return maxHp; } set { maxHp = value; } }
        public int Damage { get { return damage; } set { damage = value; } }
        public char C { get { return c; } set { c = value; } }
        public bool IsDead { get { return isDead; } set { isDead = value; } }


        public Character(int x, int y, char character) : base(x, y)
        {
            
        }

        string[] characterVision = new string[]
        {
            "NoMovement", "Up", "Down", "Left", "Right"
            
        };//change to 1D


        public enum Movement
        {
            NoMovement,
            Up,
            Down,
            Left,
            Right,
        }

        public virtual void Attack(Character target)
        {
            hp = hp - damage;


        }

        public virtual bool CheckRange(Character target)
        {
            if (DistanceTo(target) <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int DistanceTo(Character target)
        {

            int distanceX = target.X - this.X;
            int distanceY = target.Y - this.Y;
            return Math.Abs(distanceX + distanceY);
        }

        public void Move(Movement move)
        {
            switch (move)
            {
                case Movement.NoMovement: 
                    //no movement
                    break;
                case Movement.Up:
                    this.Y += 1;

                    break;
                case Movement.Down:
                    this.Y -= 1;

                    break;
                case Movement.Left:
                    this.X -= 1;

                    break;
                case Movement.Right:
                    this.X += 1;

                    break;
                default:
                    break;
            }
        }

        public abstract Movement ReturnMove(Movement move = 0);


        public abstract override string ToString();
        

    }
}
