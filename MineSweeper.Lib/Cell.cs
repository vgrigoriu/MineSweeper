
namespace MineSweeper.Lib
{
    public class Cell
    {
        public CellType Type { get; private set; }
        public int NearbyBombsCount { get; private set; }

        public Cell(CellType cellType, int nearbyBombsCount)
        {
            Type = cellType;
            NearbyBombsCount = nearbyBombsCount;
        }
    }
}
