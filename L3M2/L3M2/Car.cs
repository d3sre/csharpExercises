using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3M2
{
    public abstract class Car
    {
        private int currSpeed;
        private int maxSpeed;
        public int Speed { get; set; }
        public string DesireeSacher { get; set; }

        public Car()
        {
            
        }

        public Car(int currSpeed) : this() { }

        public virtual string GetTopFeature()
        {
            return "Bose Sound System";
        }
    }
}
