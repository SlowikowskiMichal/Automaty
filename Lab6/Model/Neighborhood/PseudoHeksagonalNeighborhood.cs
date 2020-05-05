using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class PseudoHeksagonalNeighborhood : Neighborhood
    {

        GridController gc;

        public PseudoHeksagonalNeighborhood()
        {
            gc = GridController.GetInstance();
        }

        public override List<Point> GetNeighborhood(int CellX, int CellY, int SizeX, int SizeY, BoundaryConditions condition)
        {
            List<Point> cellNeighborIndexes = new List<Point>();
            if (gc.Iteration % 2 == 0)
            {
                cellNeighborIndexes.Add(new Point(CellX - 1, CellY - 1));
                cellNeighborIndexes.Add(new Point(CellX - 1, CellY));
                cellNeighborIndexes.Add(new Point(CellX - 1, CellY + 1));
                cellNeighborIndexes.Add(new Point(CellX, CellY - 1));
                cellNeighborIndexes.Add(new Point(CellX, CellY + 1));
                cellNeighborIndexes.Add(new Point(CellX + 1, CellY - 1));
                cellNeighborIndexes.Add(new Point(CellX + 1, CellY));
                cellNeighborIndexes.Add(new Point(CellX + 1, CellY + 1));
            }
            else
            {
                cellNeighborIndexes.Add(new Point(CellX - 1, CellY));
                cellNeighborIndexes.Add(new Point(CellX, CellY - 1));
                cellNeighborIndexes.Add(new Point(CellX, CellY + 1));
                cellNeighborIndexes.Add(new Point(CellX + 1, CellY));
            }
            CheckForBoundaryCondition(cellNeighborIndexes, SizeX, SizeY, condition);
            return cellNeighborIndexes;
        }
    }
}
