using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_Abstract_Planets
{
    //This class is a child of Planet .It has oxygen as a more specific feature. It represents habitable planets.
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++
        private bool _oxygen;


        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // PUBLLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public bool HasMoons()
        {
            return (this.MoonCount < 0) ? true : false;
        }

        public bool Habitable()
        {
            return (this._oxygen == true) ? true : false;
        }
    }
}