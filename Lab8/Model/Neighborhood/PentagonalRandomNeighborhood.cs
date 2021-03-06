﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class PentagonalRandomNeighborhood : Neighborhood
    {
        public PentagonalRandomNeighborhood()
        {
            NumberOfNeighbors = 5;
        }
        override public List<Point> GetNeighborhood(int CellX, int CellY, int SizeX, int SizeY, BoundaryConditions condition)
        {
            Random r = new Random();
            List<Point> cellNeighborIndexes = new List<Point>();
            switch (r.Next(0,3))
            { 
                case 0:
                    cellNeighborIndexes.Add(new Point(CellX, CellY - 1));
                    cellNeighborIndexes.Add(new Point(CellX, CellY + 1));
                    cellNeighborIndexes.Add(new Point(CellX + 1, CellY - 1));
                    cellNeighborIndexes.Add(new Point(CellX + 1, CellY));
                    cellNeighborIndexes.Add(new Point(CellX + 1, CellY + 1));
                    break;
            case 1:
                    cellNeighborIndexes.Add(new Point(CellX - 1, CellY - 1));
                    cellNeighborIndexes.Add(new Point(CellX - 1, CellY));
                    cellNeighborIndexes.Add(new Point(CellX, CellY - 1));
                    cellNeighborIndexes.Add(new Point(CellX + 1, CellY - 1));
                    cellNeighborIndexes.Add(new Point(CellX + 1, CellY));
                    break;
                case 2:
                    cellNeighborIndexes.Add(new Point(CellX - 1, CellY));
                    cellNeighborIndexes.Add(new Point(CellX - 1, CellY + 1));
                    cellNeighborIndexes.Add(new Point(CellX, CellY + 1));
                    cellNeighborIndexes.Add(new Point(CellX + 1, CellY));
                    cellNeighborIndexes.Add(new Point(CellX + 1, CellY + 1));
                    break;
            case 3:
                    cellNeighborIndexes.Add(new Point(CellX - 1, CellY - 1));
                    cellNeighborIndexes.Add(new Point(CellX - 1, CellY));
                    cellNeighborIndexes.Add(new Point(CellX - 1, CellY + 1));
                    cellNeighborIndexes.Add(new Point(CellX, CellY - 1));
                    cellNeighborIndexes.Add(new Point(CellX, CellY + 1));
                    break;
            }

            CheckForBoundaryCondition(cellNeighborIndexes, SizeX, SizeY, condition);
            return cellNeighborIndexes;
        }
    }
}
