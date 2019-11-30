using System;
using System.Collections.Generic;
using System.Text;

namespace Andreu
{

    public class Company
    {

        private string _name;
        private double _saveproject;

        public string Name { get { return _name; } }
        public double SaveProject { get { return _saveproject; } }

        public Company(string name, double saveproject) {_name = name; _saveproject = saveproject; }

        public void Save(double save) { _saveproject += save; }

        public void Spend(double save) { _saveproject -= save; }
        public void ChangeName(string name) { _name = name; }

    }
}


