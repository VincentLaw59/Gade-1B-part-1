namespace Gade_1B_part_1
{
    public partial class frmGame : Form
    {

        public frmGame()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Map Game = new Map(10, 20, 10, 20, 8);
            
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
                //redPlayArea.Controls.Add();
            }
            
        }
    }
}