using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MineSweeper.Lib;

namespace MineSweeperTest
{
    [TestClass]
    public class TableTests
    {
        [TestMethod]
        public void TableDimensionEquals10()
        {
            var table = new Table();

            Assert.AreEqual(10, table.Dimension);
        }

        [TestMethod]
        public void BombNumberInCellEquals0()
        {
            var table = new Table();
            var cell = table.GetCell(7, 7);

            Assert.AreEqual(0, cell.NearbyBombsCount);
        }

        [TestMethod]
        public void BombCellIsProperlyInitialized()
        {
            var table = new Table(new Coordinate(1, 1));
            var cell = table.GetCell(1, 1);

            Assert.AreEqual(CellType.Bomb, cell.Type);
        }

        [TestMethod]
        public void SingleBombNeighborHasCorrectValue()
        {
            var table = new Table(new Coordinate(9, 9));
            var cell = table.GetCell(9, 8);

            Assert.AreEqual(1, cell.NearbyBombsCount);
        }

        [TestMethod]
        public void GetCell_OneBomb_OnGettingNeighborIsOfTypeSafe()
        {
            var table = new Table(new Coordinate(9, 9));
            var cell = table.GetCell(9, 8);

            Assert.AreEqual(CellType.Safe, cell.Type);
        }

        [TestMethod]
        public void TableConstructor_TakesListOfBombPositions_AndRemembersThem()
        {
            var table = new Table(
                new Coordinate(5, 0),
                new Coordinate(2, 8)
            );

            var cell = table.GetCell(5, 0);
            Assert.AreEqual(CellType.Bomb, cell.Type);
        }


    }
}
