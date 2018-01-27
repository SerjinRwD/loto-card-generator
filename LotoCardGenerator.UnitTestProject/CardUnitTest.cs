using LotoCardGenerator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LotoCardGenerator.UnitTestProject
{
    [TestClass]
    public class CardUnitTest
    {
        [TestMethod]
        public void TestException()
        {
            var card = new Card();
            int v;
            var outers = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(1, 0),
                new Tuple<int, int>(1, 91),
                new Tuple<int, int>(0, 1),
                new Tuple<int, int>(0, 91)
            };

            foreach (var t in outers)
            {
                try
                {
                    v = card[t.Item1, t.Item2];
                }
                catch (ArgumentOutOfRangeException)
                { }
            }

            card[1, 1] = Card.EMPTY_VALUE;
            card[2, 1] = Card.NO_VALUE;
        }

        [TestMethod]
        public void TestEmptyColumnsCount()
        {
            var card = new Card();

            for (int i = Card.MIN_COLUMN_ID; i <= Card.COLUMNS_COUNT; i++)
            {
                Assert.AreEqual(0, card.GetEmptyCellsInColumnsCount(i));
            }

            for (int i = Card.MIN_COLUMN_ID; i <= Card.COLUMNS_COUNT; i++)
            {
                for (int j = Card.MIN_ROW_ID; j <= Card.ROWS_COUNT; j++)
                {
                    card[j, i] = Card.EMPTY_VALUE;
                    Assert.AreEqual(j, card.GetEmptyCellsInColumnsCount(i));
                }
            }
        }

        [TestMethod]
        public void TestEmptyRowsCount()
        {
            var card = new Card();

            for (int i = Card.MIN_ROW_ID; i <= Card.MAX_ROW_ID; i++)
            {
                Assert.AreEqual(0, card.GetEmptyCellsInRowCount(i));
            }

            for (int i = Card.MIN_ROW_ID; i <= Card.MAX_ROW_ID; i++)
            {
                for (int j = Card.MIN_COLUMN_ID; j <= Card.COLUMNS_COUNT; j++)
                {
                    card[i, j] = Card.EMPTY_VALUE;
                    Assert.AreEqual(j, card.GetEmptyCellsInRowCount(i));
                }
            }
        }

        [TestMethod]
        public void TestRowToString()
        {
            var card = new Card();
            var expected = "1020 40 55 X ";

            card[1, 1] = 10;
            card[1, 2] = 20;
            card[1, 3] = Card.EMPTY_VALUE;
            card[1, 4] = 40;
            card[1, 5] = Card.EMPTY_VALUE;
            card[1, 6] = 55;
            card[1, 7] = Card.EMPTY_VALUE;
            card[1, 8] = Card.NO_VALUE;
            card[1, 9] = Card.EMPTY_VALUE;

            Assert.AreEqual(expected, card.RowToString(1));
        }
    }
}
