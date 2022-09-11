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
                for (int i = 0; i < Game.MapHeight; i++)
                {
                    Tile VerticalEntity = Game.gameMap[k, i]; 
                    VerticalEntity.X
                }
                //redPlayArea.Controls.Add();
            }
            
        }
    }
}