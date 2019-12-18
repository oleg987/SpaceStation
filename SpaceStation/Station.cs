using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    class Station : ISpaceObject
    {
        private static int currentId = 1;

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Station(int x, int y)
        {
            Id = currentId++;
            X = x;
            Y = y;
        }

        public double GetDistance(ISpaceObject spaceObject)
        {
            throw new NotImplementedException();
        }
    }
}
