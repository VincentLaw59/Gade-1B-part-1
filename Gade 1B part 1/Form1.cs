namespace Gade_1B_part_1
{
    public partial class frmGame : Form
    {
        private static GameEngine directionMap = new GameEngine();
        private static GameEngine? gameEngine;
        //private static Map? enemyNames;
        Map Game;
        private static Character? enemyCharacter;
        public static GameEngine DirectionMap { get { return directionMap!; } set { directionMap = value; } }
        //public static Map? EnemyNames { get { return enemyNames!; } set { enemyNames = value; } }
        public static Character? EnemyCharacter { get { return enemyCharacter!; } set { EnemyCharacter = value; } }
        public static GameEngine? MyGameEngine { get { return gameEngine; } set { gameEngine = value; } }
        public frmGame() 
        {
            InitializeComponent();
        }

        public void UpdateMap(Map Game)
        {
            redPlayArea.Clear();
            for (int k = 0; k < Game.MapWidth; k++)
            {
                string verticalString = "";
                for (int i = 0; i < Game.MapHeight; i++)
                {
                    Tile VerticalEntity = Game.gameMap[k, i];

                    if (VerticalEntity == null)
                    {
                        Game.gameMap[k, i] = new EmptyTile(k, i);
                    }
                    
                    if (VerticalEntity is EmptyTile)
                    {
                        verticalString += "." + "\t";
                    }
                    else if (VerticalEntity is Enemy)
                    {
                        verticalString += "E" + "\t";
                    }
                    else if (VerticalEntity is Hero)
                    {
                        verticalString += "H" + "\t";
                    }
                    else if (VerticalEntity is Obstacle)
                    {
                        verticalString += "X" + "\t";
                    }
                }
                redPlayArea.AppendText(verticalString + "\n");
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            Game = directionMap.Map;
            
            UpdateMap(Game);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            directionMap?.MovePlayer(Character.MovementEnum.Left);
            UpdateMap(Game);
            
        }

        private void bntUp_Click(object sender, EventArgs e)
        {
            directionMap?.MovePlayer(Character.MovementEnum.Up);
            UpdateMap(Game);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            directionMap?.MovePlayer(Character.MovementEnum.Right);
            UpdateMap(Game);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            directionMap?.MovePlayer(Character.MovementEnum.Down);
            UpdateMap(Game);
        }

        private void AttackBtn_Click(object sender, EventArgs e)
        {
            MyGameEngine?.Map.Player.CheckRange(Map.Enemies[EnemyList.SelectedIndex]);
        }

        private void ListOfEnemies_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Map.Enemies.Length; i++)
            {
                EnemyList.Items.Add(Map.Enemies[i].ToString());
            }
        }

        //private void EnemyList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < Map.Enemies.Length; i++)
        //    {
        //        EnemyList.Items.Add(Map.Enemies[i].ToString());
        //    }



        //}
    }
}