using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    internal class GameEngine
    {
        private Map gameMap;


        public Map GameMap { get { return gameMap; } set { gameMap = value; } }


        public GameEngine()
        {
            gameMap = new Map(5, 15, 5, 15, 3);
        }

        public bool MovePlayer(Character.MovementEnum direction)
        {
                int old_x = gameMap.Player.X;
                int old_y = gameMap.Player.Y;

                gameMap.UpdateVision();
                gameMap.player.Move(gameMap.Player.ReturnMove(direction));

                //Turn previous spot into empty space
                gameMap.gameMap[old_x, old_y] = new EmptyTile(old_x, old_y);
                gameMap.UpdateVision();
                return true;

        }

        public void AttackEnemy(Enemy target)
        {
            if (target != null)
            {
                if (GameMap.Player.CheckRange(target))
                {
                    GameMap.Player.Attack(target);
                    MessageBox.Show("attacked enemy");
                }
                else MessageBox.Show("Not in range to attack");

                if (target.isDead() == true)
                {
                    gameMap.gameMap[target.X, target.Y] = new EmptyTile(target.X, target.Y);
                    MessageBox.Show("enemy died");
                }
            }
        }
    }
}
