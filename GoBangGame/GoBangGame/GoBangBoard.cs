namespace GoBangGame
{
    public class GoBangBoard
    {
        public enum GridStatus
        {
            Empty,
            Black,
            White,
        }

        private GridStatus[,] grids;

        public GoBangBoard(int rowCount, int colomnCount)
        {
            grids = new GridStatus[rowCount, colomnCount];   
        }

        public GridStatus this[int row, int col]
        {
            get { return grids[row, col]; }
        }
    }
}