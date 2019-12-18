using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    class Asteroid : ISpaceObject
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Asteroid(int id, int x, int y)
        {
            Id = id;
            X = x;
            Y = y;
        }

        public double GetDistance(ISpaceObject spaceObject)
        {
            throw new NotImplementedException();
        }
    }
}
