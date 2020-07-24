using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_Abstract_Planets
{
    //This class is the parent class where the different types of planets derive from.
    abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private int _rotationPeriod;

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        // PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public double Diameter
        {
            get
            {
                return this._diameter;      // Read-Only
            }
        }

        public double Mass
        {
            get
            {
                return this._mass;          // Read-Only
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;         // Read-Only
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public int RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        // PUBLIC METHOD +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public override string ToString()
        {
            string _dia = this._diameter.ToString();
            string _mass = this._mass.ToString();

            return this._name + "\n" + "Diameter : " + _dia + "\nMass : " + _mass + "\n";
        }
    }
}