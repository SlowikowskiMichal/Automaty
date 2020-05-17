using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class NeumannNeighborhood : Neighborhood
    {
        public NeumannNeighborhood()
        {
            NumberOfNeighbors = 4;
        }
        public override List<Point> GetNeighborhood(int CellX, int CellY, int SizeX, int SizeY, BoundaryConditions condition)
        {
            List<Point> cellNeighborIndexes = new List<Point>();

            cellNeighborIndexes.Add(new Point(CellX - 1, CellY));
            cellNeighborIndexes.Add(new Point(CellX, CellY - 1));
            cellNeighborIndexes.Add(new Point(CellX, CellY + 1));
            cellNeighborIndexes.Add(new Point(CellX + 1, CellY));

            CheckForBoundaryCondition(cellNeighborIndexes, SizeX, SizeY, condition);

            return cellNeighborIndexes;
        }
    }
}
