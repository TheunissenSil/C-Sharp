using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Person
    {
        public string name;
        public int age;
        public int weight;
        public int height;

        // Constructor which only sets the name
        public Person(string name) : this(name, 0, 0, 0)
        {
        }

        // Constructor to set name and age
        public Person(string name, int age) : this(name, age, 0, 0)
        {
        }

        // Constructor to set all the variables.
        // The two constructors above call this when they are used.
        public Person(string name, int age, int weight, int height)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        public double BodyMassIndex()
        {
            double heigthPerHundred = this.height / 100.0;
            return this.weight / (heigthPerHundred * heigthPerHundred);
        }

        public double MaximumHeartRate()
        {
            return 206.3 - (0.711 * this.age);
        }

        public bool IsAdult()
        {
            if (this.age < 18)
            {
                return false;
            }
            return true;
        }

        public void GrowOlder()
        {
            this.GrowOlder(1);
        }

        public void GrowOlder(int years)
        {
            this.age += years;
        }

        public override string ToString()
        {
            return this.name + ", age " + this.age + " years";
        }

    }
}
