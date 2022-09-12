namespace Gade_1B_part_1
{
    public partial class frmGame : Form
    {
        private static GameEngine gameEngine = new GameEngine();
        //private GameEngine gameEngine;
        //private static Map? enemyNames;
        Map Game;
        //private static Character? enemyCharacter;

        public static GameEngine GameEngine { get { return gameEngine; } set { gameEngine = value; } }
        //public static Map? EnemyNames { get { return enemyNames!; } set { enemyNames = value; } }
        //public static Character EnemyCharacter { get { return enemyCharacter!; } set { enemyCharacter = value; } }
        //public GameEngine MyGameEngine { get { return gameEngine; } set { gameEngine = value; } }
        
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

                    VerticalEntity = Game.gameMap[k, i];

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
            Game = gameEngine.Map;
            UpdateMap(Game);

            for (int i = 0; i < Game.Enemies.Length; i++)
            {
                CmbListOfEnemies.Items.Add(Game.Enemies[i].ToString());
            }

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Character.MovementEnum.Left);
            UpdateMap(Game);
            
        }

        private void bntUp_Click(object sender, EventArgs e)
        {
            gameEngine?.MovePlayer(Character.MovementEnum.Up);
            UpdateMap(Game);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            gameEngine?.MovePlayer(Character.MovementEnum.Right);
            UpdateMap(Game);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            gameEngine?.MovePlayer(Character.MovementEnum.Down);
            UpdateMap(Game);
        }

        private void AttackBtn_Click(object sender, EventArgs e)
        {
            if (CmbListOfEnemies.SelectedIndex == -1) return;
           bool inRange =  gameEngine.Map.Player.CheckRange(Game.Enemies[CmbListOfEnemies.SelectedIndex]);

          if (inRange)
          {
                MessageBox.Show("I am Attacking!!!!!");
          }
            else
            {
                MessageBox.Show("I can not Attack????");
            }


        }

        private void ListOfEnemies_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListOfEnemies_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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