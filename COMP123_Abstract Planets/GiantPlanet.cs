using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_Abstract_Planets
{
    //This class is a subclass of Planet and represents the biggest planets. It includes two types of planets
    // Ice or Gas
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++
        private string _type;

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;
        }

        // // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++
        public bool HasMoons()
        {
            return (this.MoonCount > 0) ? true : false;
        }

        public bool HasRings()
        {
            return (this.RingCount > 0) ? true : false;
        }
    }
}