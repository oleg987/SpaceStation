using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    public interface ISpaceObject
    {
        int Id { get; set; }
        int X { get; set; }
        int Y { get; set; }

        double GetDistance(ISpaceObject spaceObject);
    }
}
