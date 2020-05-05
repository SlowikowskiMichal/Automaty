using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class NeighborhoodManager
    {
        static Neighborhood[] ImplementedNeighborhood = {new MooresNeighborhood(), new NeumannNeighborhood(),
            new HexagonalLeftNeighborhood(), new HexagonalRightNeighborhood(), new HexagonalRandomNeighborhood(),
            new PentagonalLeftNeighborhood(), new PentagonalRightNeighborhood(), new PentagonalTopNeighborhood(),
            new PentagonalBottomNeighborhood(), new PentagonalRandomNeighborhood(),new PseudoHeksagonalNeighborhood(),
            new RectangleNeighborhood()};



        public List<Neighborhood> CurrentNeighborhoods;
        public enum RandomNeighborhoodMode
        {
            None,
            Toggle,
            MultipleNeighborhoods,
            Direction
        }

        public List<double> RandomThresholdList;


        public RandomNeighborhoodMode _RandomMode;
        public RandomNeighborhoodMode RandomMode 
        { 
            get { return _RandomMode; } 
            set 
            { 
                _RandomMode = value;
                switch (RandomMode)
                {
                    case RandomNeighborhoodMode.None:
                        GetNeighborhoodFunction = GetNeighborhoodRandomNone;
                        break;
                    case RandomNeighborhoodMode.Toggle:
                        GetNeighborhoodFunction = GetNeighborhoodRandomToggle;
                        break;
                    case RandomNeighborhoodMode.MultipleNeighborhoods:
                        GetNeighborhoodFunction = GetNeighborhoodRandomMultiple;
                        break;
                    case RandomNeighborhoodMode.Direction:
                        GetNeighborhoodFunction = GetNeighborhoodRandomDirection;
                        break;
                    default:
                        GetNeighborhoodFunction = GetNeighborhoodRandomNone;
                        break;
                }
            } 
        }

        Func<int, int, int, int, BoundaryConditions, List<Point>> GetNeighborhoodFunction;

        public bool IsRandomModeMultiNeighborhood()
        {
            switch(RandomMode)
            {
                case RandomNeighborhoodMode.None:
                    return false;
                case RandomNeighborhoodMode.Toggle:
                    return false;
                case RandomNeighborhoodMode.MultipleNeighborhoods:
                    return true;
                case RandomNeighborhoodMode.Direction:
                    return false;
                default:
                    return false;
            }
        }

        public NeighborhoodManager(int index = 0)
        {
            
            CurrentNeighborhoods = new List<Neighborhood>();
            CurrentNeighborhoods.Add(ImplementedNeighborhood[index]);
            RandomThresholdList = new List<double>();
            RandomMode = RandomNeighborhoodMode.None;
        }
        public int GetNumberOfNeighbors(int index = 0)
        {
            return CurrentNeighborhoods?[index]?.NumberOfNeighbors ?? 0;
        }
        public void SetNeighborhood(List<int> neighborhoodIndexList)
        {
            CurrentNeighborhoods = neighborhoodIndexList.Select(v => ImplementedNeighborhood[v]).ToList();
        }

        
        internal List<Point> GetNeighborhood(int x, int y, int sizeX, int sizeY, BoundaryConditions boundaryCondition)
        {
            return GetNeighborhoodFunction(x, y, sizeX, sizeY, boundaryCondition);
        }

        internal List<Point> GetNeighborhoodRandomNone(int x, int y, int sizeX, int sizeY, BoundaryConditions boundaryCondition)
        {
            return CurrentNeighborhoods[0].GetNeighborhood(x, y, sizeX, sizeY, boundaryCondition);
        }

        internal List<Point> GetNeighborhoodRandomToggle(int x, int y, int sizeX, int sizeY, BoundaryConditions boundaryCondition)
        {
            var val = new Random().NextDouble();
            return val >= RandomThresholdList[0] ? CurrentNeighborhoods[0].GetNeighborhood(x, y, sizeX, sizeY, boundaryCondition) : new List<Point>();
        }

        internal List<Point> GetNeighborhoodRandomMultiple(int x, int y, int sizeX, int sizeY, BoundaryConditions boundaryCondition)
        {
            var val = new Random().NextDouble();
            double sum = 0.0;
            for(int i = 0; i < RandomThresholdList.Count; i++)
            {
                sum += RandomThresholdList[i];
                if(val <= sum)
                {
                    return CurrentNeighborhoods[i].GetNeighborhood(x, y, sizeX, sizeY, boundaryCondition);
                }
            }
            return new List<Point>();
        }

        internal List<Point> GetNeighborhoodRandomDirection(int x, int y, int sizeX, int sizeY, BoundaryConditions boundaryCondition)
        {
            Random r = new Random();
            return CurrentNeighborhoods[0].GetNeighborhood(x, y, sizeX, sizeY, boundaryCondition).Where((v, i) => RandomThresholdList[i] <= r.NextDouble()).ToList();
        }
    }
}
