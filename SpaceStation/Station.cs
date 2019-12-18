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

        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Station(int x, int y)
        {
            Id = currentId++;
            X = x;
            Y = y;

            Space.GetInstance().SpaceObjects.Add(this);
        }

        public delegate void StationCrashDelegate(ISpaceObject station, ISpaceObject obj);
        public event StationCrashDelegate OnCrash;

        public double GetDistance(ISpaceObject spaceObject)
        {
            return (Math.Sqrt(Math.Pow(X - spaceObject.X, 2) + Math.Pow(Y - spaceObject.Y, 2)));
        }

        public void CheckDistance()
        {
            foreach (ISpaceObject item in Space.GetInstance().SpaceObjects)
            {
                if (item.Id == Id && GetType() == typeof(Station))
                {
                    continue;
                }

                if (GetDistance(item) == 0)
                {
                    OnCrash?.Invoke(this, item);
                }
            }
        }
    }
}
