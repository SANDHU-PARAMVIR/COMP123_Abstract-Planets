using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_Abstract_Planets
{
    //This interface is used by the Planet classes and returns a boolean variable depending on whether or not
    //a planet has Moons.
    public interface IHasMoons
    {
        bool HasMoons();
    }
}