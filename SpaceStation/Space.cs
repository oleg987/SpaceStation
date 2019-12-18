using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    class Space
    {
        public int XDimention { get; set; }
        public int YDimention { get; set; }
        public List<ISpaceObject> SpaceObjects { get; set; }

        public Space(int xDimention, int yDimention, int asteroidCount)
        {
            XDimention = xDimention;
            YDimention = yDimention;
        }


    }
}
