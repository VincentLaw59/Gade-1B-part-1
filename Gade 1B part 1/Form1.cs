namespace Gade_1B_part_1
{
    public partial class frmGame : Form
    {
        private static GameEngine? directionMap;
        private static GameEngine? gameEngine;
        private static Map? enemyNames;
        Map Game = new Map(5, 10, 5, 10, 8);
        private static Character? enemyCharacter;
        public static GameEngine DirectionMap { get { return directionMap!; } set { directionMap = value; } }
        public static Map? EnemyNames { get { return enemyNames!; } set { enemyNames = value; } }
        public static Character? EnemyCharacter { get { return enemyCharacter!; } set { EnemyCharacter = value; } }
        public static GameEngine? MyGameEngine { get { return gameEngine; } set { gameEngine = value; } }
        public frmGame() 
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Map Game = new Map(5, 10, 5, 10, 8);
            
            for (int k = 0; k < Game.MapWidth; k++)
            {
                string verticalString = "";
                for (int i = 0; i < Game.MapHeight; i++)
                {
                    Tile VerticalEntity = Game.gameMap[k, i];

                    if (VerticalEntity == null)
                    {
                        Game.gameMap[k, i] = new EmptyTile(k, i);
                        verticalString += "." + "\t";
                    }
                    else if (VerticalEntity is Enemy)
                    {
                        verticalString += "E" + "\t" ;
                    }
                    else if (VerticalEntity is Hero)
                    {
                        verticalString += "H" + "\t" ;
                    }
                    else if (VerticalEntity is Obstacle)
                    {
                        verticalString += "X" + "\t" ;
                    }
                    //else MessageBox.Show(verticalString.ToString());
                }
                redPlayArea.AppendText(verticalString + "\n");
            }
            //MessageBox.Show("This shows if everything executed");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            DirectionMap?.MovePlayer(Character.MovementEnum.Left);
        }

        private void bntUp_Click(object sender, EventArgs e)
        {
            DirectionMap?.MovePlayer(Character.MovementEnum.Up);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            DirectionMap?.MovePlayer(Character.MovementEnum.Right);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            DirectionMap?.MovePlayer(Character.MovementEnum.Down);
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