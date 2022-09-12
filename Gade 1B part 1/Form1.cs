namespace Gade_1B_part_1
{
    public partial class frmGame : Form
    {
        private static GameEngine gameEngine = new GameEngine();
        Map Game;


        public static GameEngine GameEngine { get { return gameEngine; } set { gameEngine = value; } }

        
        public frmGame() 
        {
            InitializeComponent();
        }

        public void UpdateMap(Map Game)
        {
            redPlayArea.Clear();
            //redPlayArea.AppendText(gameEngine.ToString());
            
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
            //Generate Map
            Game = gameEngine.Map;
            UpdateMap(Game);
            redOutput.Text = gameEngine.Map.player.ToString();

            for (int i = 0; i < Game.Enemies.Length; i++)
            {
                CmbListOfEnemies.Items.Add(Game.Enemies[i].ToString());
            }

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            
            gameEngine.MovePlayer(Character.MovementEnum.Left);
            Game.gameMap[gameEngine.Map.Player.X, gameEngine.Map.Player.Y] = gameEngine.Map.Player; //Up
            UpdateMap(Game);
            

        }

        private void bntUp_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Character.MovementEnum.Up);
            Game.gameMap[gameEngine.Map.Player.X, gameEngine.Map.Player.Y] = gameEngine.Map.Player;
            UpdateMap(Game);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Character.MovementEnum.Right);
            Game.gameMap[gameEngine.Map.Player.X, gameEngine.Map.Player.Y] = gameEngine.Map.Player;
            UpdateMap(Game);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Character.MovementEnum.Down);
            Game.gameMap[gameEngine.Map.Player.X, gameEngine.Map.Player.Y] = gameEngine.Map.Player;
            UpdateMap(Game);
        }

        private void AttackBtn_Click(object sender, EventArgs e)
        {
           // if (CmbListOfEnemies.SelectedIndex == -1) return;
           bool inRange =  gameEngine.Map.player.CheckRange(Game.Enemies[CmbListOfEnemies.SelectedIndex]);

          if (inRange)
          {
                //MessageBox.Show("I am Attacking!!!!!");
                redOutput.Lines.Append("I have attacked!" + "\n" + Game.Enemies[CmbListOfEnemies.SelectedIndex].ToString());
                gameEngine.Map.Player.Attack(Game.Enemies[CmbListOfEnemies.SelectedIndex]);
          }
            else
            {
                //MessageBox.Show("I can not Attack????");
                redOutput.Lines.Append("I cannot attack?" + "\n" + Game.Enemies[CmbListOfEnemies.SelectedIndex].ToString());
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