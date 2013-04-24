
using System;
using System.Collections.Generic;
using System.Linq;

namespace MineSweeper.Lib
{
    public class Table
    {
        private readonly List<Coordinate> bombPositionOnTable;
        public int Dimension { get; private set; }

        public Table(params Coordinate[] bombPositions)
        {
            Dimension = 10;

            bombPositionOnTable = bombPositions.ToList();
        }

        public Cell GetCell(int line, int column)
        {
            if (bombPositionOnTable.Any(b => b.Line == line)
                && bombPositionOnTable.Any(b => b.Column == column))
                return new Cell(CellType.Bomb, 0);

            var bombs =
                bombPositionOnTable.Count(
                tuple => Math.Abs(tuple.Line - line) <= 1
                    && Math.Abs(tuple.Column - column) <= 1);
            return new Cell(CellType.Safe, bombs);

        }
    }
}
