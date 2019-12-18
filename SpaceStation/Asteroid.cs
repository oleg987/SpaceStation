using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    class Asteroid : ISpaceObject
    {
        private static int currentId = 1;

        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Asteroid(int x, int y)
        {
            Id = currentId++;
            X = x;
            Y = y;
        }

        public double GetDistance(ISpaceObject spaceObject)
        {
            return (Math.Sqrt(Math.Pow(X - spaceObject.X, 2) + Math.Pow(Y - spaceObject.Y, 2)));
        }
    }
}
