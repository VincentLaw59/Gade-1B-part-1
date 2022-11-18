﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    internal class Hero: Character
    {
        public Hero(int x, int y, char character = 'H', int hp = 10): base(x, y, character)
        {
            HP = hp;
            MaxHp = hp;
            Damage = 2;
            weaponReach = 1;
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            //Move Up
            if (move == MovementEnum.Up)
                if ((vision[1] is not Obstacle) && (vision[1] is not SwampCreature))
                {
                    return move;
                }
                else
                {
                    move = MovementEnum.NoMovement;
                    return move;
                }

            //Move Down
            else if (move == MovementEnum.Down)
                    if ((vision[2] is not Obstacle) && (vision[2] is not SwampCreature))
                        return move;
                    else
                    {
                        move = MovementEnum.NoMovement;
                        return move;
                    }

                //Move Left
                else if (move == MovementEnum.Left)
                    if ((vision[3] is not Obstacle) && (vision[3] is not SwampCreature))
                        return move;
                    else
                    {
                        move = MovementEnum.NoMovement;
                        return move;
                    }

                //Move Right
                else if (move == MovementEnum.Right)
                    if ((vision[4] is not Obstacle) && (vision[4] is not SwampCreature))
                        return move;
                    else
                    {
                        move = MovementEnum.NoMovement;
                        return move;
                    }

                else move = MovementEnum.NoMovement;

            return move;
        }

        public override string ToString()
        {
            return "Player Stats:" + 
                    "\n HP: " + HP + "/" + MaxHp + 
                    "\n Damage: " + Damage + 
                    "\n [" + X + "," + Y + "]\n"; 
        }
    }
}
