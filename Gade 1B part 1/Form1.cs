namespace Gade_1B_part_1
{
    public partial class frmGame : Form
    {
        private static Map? directionMap;

        public static Map DirectionMap { get { return directionMap!; } set { directionMap = value; } }
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
                    
                    if (VerticalEntity != null)
                    {
                        Game.gameMap[k, i] = new EmptyTile(k, i);
                        verticalString += "\t.";
                    }
                    else if (VerticalEntity is Enemy)
                    {
                        verticalString += "\t" + (char)190;
                    }
                    else if (VerticalEntity is Hero)
                    {
                        verticalString += "\t" + (char)208;
                    }
                }
                redPlayArea.Text = verticalString + "\n";
            }
            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            DirectionMap.Player.Move(Character.MovementEnum.Left);
        }

        private void bntUp_Click(object sender, EventArgs e)
        {
            DirectionMap.Player.Move(Character.MovementEnum.Up);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            DirectionMap.Player.Move(Character.MovementEnum.Right);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            DirectionMap.Player.Move(Character.MovementEnum.Down);
        }
    }
}