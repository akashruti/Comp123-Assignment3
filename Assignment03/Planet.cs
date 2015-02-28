﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    abstract class Planet
    {
        //Private Instance Variables +++++++++++++++++++++===

        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;


        // Public Properties
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        public double Mass
        {
            get
            {
                return this._mass;
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
            }
        }

        public string Name
        {
            get
            {
                return this._name;
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
            }
        }

    }
}
