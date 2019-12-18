using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    class Space
    {
        private static Space space;

        public int XDimention { get; set; }
        public int YDimention { get; set; }
        public List<ISpaceObject> SpaceObjects { get; set; }

        private Space()
        {
            XDimention = 400;
            YDimention = 600;
            SpaceObjects = new List<ISpaceObject>();

            SpaceObjects.AddRange(new Asteroid[] { new Asteroid(50, 50), new Asteroid(350, 550), new Asteroid(50, 550) });
        }

        public static Space GetInstance()
        {
            if (space == null)
            {
                space = new Space();
            }
            return space;
        }
              

    }
}
