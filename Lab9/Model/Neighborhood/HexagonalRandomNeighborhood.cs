using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class HexagonalRandomNeighborhood : Neighborhood
    {
        public HexagonalRandomNeighborhood()
        {
            NumberOfNeighbors = 6;
        }
        override public List<Point> GetNeighborhood(int CellX, int CellY, int SizeX, int SizeY, BoundaryConditions condition)
        {
            Random r = new Random();
            List<Point> cellNeighborIndexes = new List<Point>();
            if (r.NextDouble() > 0.5)
            {
                cellNeighborIndexes.Add(new Point(CellX - 1, CellY - 1));
                cellNeighborIndexes.Add(new Point(CellX - 1, CellY));
                cellNeighborIndexes.Add(new Point(CellX, CellY - 1));
                cellNeighborIndexes.Add(new Point(CellX, CellY + 1));
                cellNeighborIndexes.Add(new Point(CellX + 1, CellY));
                cellNeighborIndexes.Add(new Point(CellX + 1, CellY + 1));
            }
            else
            {
                cellNeighborIndexes.Add(new Point(CellX - 1, CellY));
                cellNeighborIndexes.Add(new Point(CellX - 1, CellY + 1));
                cellNeighborIndexes.Add(new Point(CellX, CellY - 1));
                cellNeighborIndexes.Add(new Point(CellX, CellY + 1));
                cellNeighborIndexes.Add(new Point(CellX + 1, CellY - 1));
                cellNeighborIndexes.Add(new Point(CellX + 1, CellY));
            }

            CheckForBoundaryCondition(cellNeighborIndexes, SizeX, SizeY, condition);
            return cellNeighborIndexes;
        }
    }
}
