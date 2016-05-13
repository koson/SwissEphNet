using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweWin
{
    class Planets
    {
        private int _no;
        private string _name;
        private double _eclLong;
        private double _eclLat;
        private double _Dist;
        private double _Speed;
        private double _House;

        public double Distance
        {
            get { return _Dist; }
            set { _Dist = value; }
        }

        public double House
        {
            get { return _House; }
            set { _House = value; }
        }

        public double eclLat
        {
            get { return _eclLat; }
            set { _eclLat = value; }
        }

        public double eclLong
        {
            get { return _eclLong; }
            set { _eclLong = value; }
        }

        public double Speed
        {
            get { return _Speed; }
            set { _Speed = value; }
        }

        public int No
        {
            get { return _no; }
            set { _no = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
